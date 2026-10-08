using System;
using System.Collections.Generic;
using System.Text;

namespace PDFRepo.utils
{
    internal class MethodsInCommon
    {
        public MethodsInCommon()
        {

        }

        public DataGridViewRow GetSelectedGridRow(DataGridView dataGridView1, string opType)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
               return selectedRow;
            }
            else
            {
                MessageBox.Show($"You must a select PDF record to {opType} it.");
                return null; // Indicate that no valid ID was selected
            }
        }

        public string GetSelectedGridRowId(DataGridView dataGridView1, string opType)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                return selectedRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show($"You must a select PDF record to {opType} it.");
                return "-1"; // Indicate that no valid ID was selected
            }
        }
    }
}
