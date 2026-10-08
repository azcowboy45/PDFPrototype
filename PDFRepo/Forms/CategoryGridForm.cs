using PDFRepo.DataClasses;
using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.Forms
{
    public partial class CategoryGridForm : Form
    {
        private MethodsInCommon mic;
        public CategoryGridForm()
        {
            mic = new MethodsInCommon();  // Initialize the MethodsInCommon instance

            InitializeComponent();
            LoadDataGrid();

            // Wire up the Activated event handler programmatically
            this.Activated += CategoryGridForm_Activated;  // Wire up the Activated event handler programmatically to the CategoryGridForm.

        }

        private void CategoryGridForm_Activated(object sender, EventArgs e)
        {
            //  BuildComboBox();  // Rebuild the ComboBox when the form is activated
            // Refresh the DataGridView when the form is activated
            LoadDataGrid();
        }



        private void LoadDataGrid()
        {
            DataModel dm = new DataModel();
            DataTable dt = dm.GetAllCategories();
            dataGridView1.DataSource = dt;
            FormatDataGrid();
        }



        private void FormatDataGrid()
        {

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            // Define the default style for all rows (e.g., even rows)
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Define the style for alternating rows (e.g., odd rows)
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID"].Visible = true;
            dataGridView1.Columns["ID"].Width = 64;

            dataGridView1.Columns["category"].HeaderText = "Category";
            dataGridView1.Columns["category"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["category"].Visible = true;
            dataGridView1.Columns["category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["category"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns["notes"].HeaderText = "Description";
            dataGridView1.Columns["notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["notes"].Visible = true;


        }
        /*
        private string GetSelectedPdfId(string opType )
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                return selectedRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show($"You must select a PDF category rowin order to {opType} it.");
                return "-1"; // Indicate that no valid ID was selected
            }
        }
*/
        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CategoryInputForm cif = new CategoryInputForm();
            cif.ShowDialog();
            LoadDataGrid();

        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryInputForm cif = new CategoryInputForm();
            cif.ShowDialog();
            LoadDataGrid();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // 
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = mic.GetSelectedGridRow(dataGridView1, "modify");
            if (selectedRow == null)
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                CategoryInputForm cif = new CategoryInputForm(selectedRow);
                cif.ShowDialog();
                this.LoadDataGrid();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataModel dm = new DataModel();

            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "delete");

            if (dm.DeleteCategoryById(selectedPdfId))
            {
                LoadDataGrid();
            }
        }
    }
}
