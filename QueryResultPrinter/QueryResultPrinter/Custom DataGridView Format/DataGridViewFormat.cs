using System;
using System.Drawing;
using System.Windows.Forms;

namespace QueryResultPrinter.Custom_DataGridView_Format
{
    static class DataGridViewFormat
    {
        public static void ChangeGridViewFormat(DataGridView dataGridView)
        {
            ChangeNumberFormat(dataGridView.Columns);

            AddHeadertRowIndex(dataGridView.Rows);

            ChangeColumnHeaderFormat(dataGridView);
        }
       static void ChangeNumberFormat(DataGridViewColumnCollection dataGridViewColumnCollection)
        {
            foreach (DataGridViewColumn column in dataGridViewColumnCollection)
            {
                if (column.ValueType == typeof(Decimal))
                {
                    column.DefaultCellStyle.Format = "N2";

                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        static void AddHeadertRowIndex(DataGridViewRowCollection dataGridViewRowCollection)
        {
            foreach (DataGridViewRow row in dataGridViewRowCollection)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        static void ChangeColumnHeaderFormat(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);

            // If .EnableHeadersVisualStyles is true, it automatically follows user theme and Header`s color change won`t have effect
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
        }

        public static void UndoAutomaticRowSelection(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                return;
            }
            dataGridView.Rows[0].Selected = false;
        }

        public static void LimitUserInteractionWithDataGridView(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
