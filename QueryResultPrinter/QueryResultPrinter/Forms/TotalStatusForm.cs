using PCZInventory.Interface;
using QueryResultPrinter;
using QueryResultPrinter.Custom_DataGridView_Format;
using QueryResultPrinter.Mappers;
using QueryResultPrinter.Workers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TotalInventory
{
    public partial class TotalInventoryStatus : Form, ISearchable, IExportable
    {
        public TotalInventoryStatus()
        {
            InitializeComponent();
        }
        public void TotalInventoryStatus_Load(object sender, EventArgs e)
        {
            labelDatePicker.Text = "Reference Month";

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy.MM";
            dateTimePicker.Size = new Size(120, 20);

            DataGridViewFormat.LimitUserInteractionWithDataGridView(gridSummaryData);
            gridSummaryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            DataGridViewFormat.LimitUserInteractionWithDataGridView(gridDetailData);
            gridDetailData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            labelSelectedTypes.Visible = false;
            labelSelectedTypes.Location = new Point(labelTotalDetail.Right + 5, labelTotalDetail.Top);
            labelSelectedTypes.BorderStyle = BorderStyle.Fixed3D;

            // To make Rowheader include upto 4 digits ( Temporary resolution )
            gridDetailData.RowHeadersDefaultCellStyle.Padding = new Padding(4);
        }
        public void SummaryDataSearch()
        {
            ClearGridViewData(gridDetailData);

            ShowQueryResultToGridView(gridSummaryData, Mapper.GetGridViewSummaryCommand(this.Name), null);

            // If there`s no query result for selected year
            if (gridSummaryData.Rows.Count == 0)
            {
                ClearGridViewData(gridSummaryData);
                SetSelectionLabelText(new List<string> { "" });

                MessageBox.Show($"{dateTimePicker.Value.ToString("yyyy-MM")} is not closed yet.");

                return;
            }

            // There should not be automatic row selection when data is populated onto GridView
            DataGridViewFormat.UndoAutomaticRowSelection(gridSummaryData);

            DataGridViewFormat.ChangeGridViewFormat(gridSummaryData);

            ShowUpTypeSelectionLabel();

            // Showing up detail data is only allowed after summary data is showed up
            IsDetailDataShowUpAllowed = true;
        }

        private Action<DataGridView> ClearGridViewData = dataGridView => dataGridView.Columns.Clear();
        private Func<DataGridView, bool> AnySelection = (dataGridView) => dataGridView.SelectedRows.Count > 0;

        private void ShowUpTypeSelectionLabel()
        {
            labelSelectedTypes.Visible = true;
        }

        #nullable enable
        private void SetSelectionLabelText(List<string>? selection)
        {
            if (selection is null)
            {
                labelSelectedTypes.Text = "Selection : None";
                return;
            }

            labelSelectedTypes.Text = $"Selection : {string.Join(",  ", selection)}";
        }
        #nullable enable

        private void gridSummaryData_SelectionChanged(object sender, EventArgs e)
        {
            if (AnySelection(gridSummaryData) && IsDetailDataShowUpAllowed)
            {
                var referenceColumnName = Mapper.GetReferenceColumnName(this.Name);
                
                // This is for excluding Row 'Total' selection when a single row is chosen
                // But it works even when multiple selection, due to this method's 3 times called strange built-in feature
                ExcludeRowTotalSelection(referenceColumnName);

                var userSelection = GetSelectionInGridViewSummary(referenceColumnName);
                SetSelectionLabelText(userSelection);

                ShowQueryResultToGridView(gridDetailData, Mapper.GetGirdViewDetailCommand(this.Name), userSelection);

                DataGridViewFormat.ChangeGridViewFormat(gridDetailData);

                DataGridViewFormat.UndoAutomaticRowSelection(gridDetailData);
            }

            // When user deselects everything
            else
            {
                ClearGridViewData(gridDetailData);
                SetSelectionLabelText(null);
            }
        }

        private void ExcludeRowTotalSelection(string columnName)
        {
            DataGridViewRow singlySelectedRow = gridSummaryData.SelectedRows[0];
            if (singlySelectedRow.Cells[columnName].Value.ToString() == "")
            {
                singlySelectedRow.Selected = false;
                return;
            }
        }

        private List<string> GetSelectionInGridViewSummary(string columnName)
        {
            List<string> userSelection = new List<string>();

            foreach (DataGridViewRow row in gridSummaryData.SelectedRows)
            {
                userSelection.Add(row.Cells[columnName].Value.ToString());
            }

            return Worker.ChangeSelectionOrder(this.Name, userSelection);
        }

        #nullable enable
        private void ShowQueryResultToGridView(DataGridView dataGridView, string storedProcedure, List<string>? userSelection)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DB_Configuration.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                // When there's no user selection like showing data in GridViewSummary, query is excuted only once
                int loopCount = 0;
                if (userSelection != null)
                {
                    loopCount = userSelection.Count - 1;
                }

                for (int i = 0; i <= loopCount; i++)
                {
                    using (SqlCommand sqlCommand = new SqlCommand(storedProcedure, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@stdmonth", SqlDbType.NVarChar, 6));

                        sqlCommand.Parameters["@stdmonth"].Value = dateTimePicker.Value.ToString("yyyyMM");

                        // When showing data in GridViewDetail, there must be additional arguments passed
                        if (userSelection != null)
                        {
                            Worker.AddSecondArguments(this.Name, sqlCommand, userSelection[i]);
                        }

                        try
                        {
                            sqlConnection.Open();
                            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                            {
                                sqlDataAdapter.Fill(dataTable);
                            }
                            sqlConnection.Close();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }

                dataGridView.DataSource = dataTable;
            }
        }
        #nullable disable
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            IsDetailDataShowUpAllowed = false;
        }

        public void Export()
        {
            CopyDetailGridToClipBoard();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            string filePath = SetFilePath();

            if (filePath != "")
            {
                xlWorkBook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            else
            {
                MessageBox.Show("Please choose file path to export the content");
            }
        }

        private void CopyDetailGridToClipBoard()
        {
            gridDetailData.SelectAll();

            DataObject dataObject = gridDetailData.GetClipboardContent();
            if (dataObject != null)
            {
                Clipboard.SetDataObject(dataObject);
            }
        }

        private string SetFilePath()
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Saving file path selection",
                DefaultExt = "xlsx",
                Filter = "Excel Document|*.xlsx;*.xls;*.csv",
                CheckPathExists = true,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }

            return filePath;
        }
    }
}
