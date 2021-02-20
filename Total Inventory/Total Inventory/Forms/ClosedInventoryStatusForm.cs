using System.Windows.Forms;
using System.Data.SqlClient;
using TotalInventory;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using QueryResultPrinter.Custom_DataGridView_Format;
using System;

namespace QueryResultPrinter
{
    public partial class ClosedInventoryStatusForm : Form, ISearchable
    {
        public ClosedInventoryStatusForm()
        {
            InitializeComponent();
        }
        private void ClosedInventoryStatusForm_Load(object sender, System.EventArgs e)
        {
            DataGridViewFormat.LimitUserInteractionWithDataGridView(gridClosedMonths);
        }

        public void SummaryDataSearch()
        {
            List<List<int>> closedMonths = new List<List<int>>();
            List<string> commands = new List<string>()
            {
                DB_Configuration.FUNC_GET_CLOSED_MONTHS_tqtInOut,
                DB_Configuration.FUNC_GET_CLOSED_MONTHS_tqtInOutCKD,
                DB_Configuration.FUNC_GET_CLOSED_MONTHS_tmtInOutProd,
                DB_Configuration.FUNC_GET_CLOSED_MONTHS_tmtInOutSemi
            };

            using (SqlConnection sqlConnection = new SqlConnection(DB_Configuration.ConnectionString))
            {
                foreach (string command in commands)
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);

                            closedMonths.Add(ConvertToList(dataTable));
                        }
                        sqlConnection.Close();
                    }
                }
                gridClosedMonths.DataSource = GetCommonValue(closedMonths);
            }

            DataGridViewFormat.ChangeGridViewFormat(gridClosedMonths);
            DataGridViewFormat.UndoAutomaticRowSelection(gridClosedMonths);
        }

        private List<int> ConvertToList(DataTable dataTable)
        {
            List<int> stringedDataTable = new List<int>();

            foreach (DataRow row in dataTable.Rows)
            {
                stringedDataTable.Add(Convert.ToInt32(row["Closed months"]));
            }

            return stringedDataTable;
        }

        private DataTable GetCommonValue(List<List<int>> listOfValueLists)
        {
            DataTable dataTable = new DataTable();

            List<int> commonValuesString = new List<int>();
            List<int> referenceString = listOfValueLists[0];

            foreach (List<int> list in listOfValueLists)
            {
                commonValuesString = referenceString.Intersect(list).ToList();
            }

            PutToDataTale(dataTable, commonValuesString);

            return dataTable;
        }

        private void PutToDataTale(DataTable dataTable, List<int> str)
        {
            dataTable.Columns.Add("Closed Months");

            foreach (int rowValue in str)
            {
                dataTable.Rows.Add(rowValue);
            }
        }
    }
}
