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
    public partial class SubCatGridForm : Form
    {

        private MethodsInCommon mic;
        public SubCatGridForm()
        {
            mic = new MethodsInCommon();  // Initialize the MethodsInCommon instance
            InitializeComponent();
            subcatButton.Text = char.ConvertFromUtf32('\u2630');
            subcatButton.FlatAppearance.BorderSize = 0;

            LoadDataGrid();

            // Wire up the Activated event handler programmatically
            this.Activated += CategoryGridForm_Activated;  // Wire up the Activated event handler programmatically to the CategoryGridForm.

            AddToolTips();

        }
        
        private void AddToolTips()
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(subcatButton, "Click to manage subcategories.");
            toolTip.SetToolTip(exitButton, "Click to exit the form.");
        }

        private void CategoryGridForm_Activated(object sender, EventArgs e)
        {
            //  BuildComboBox();  // Rebuild the ComboBox when the form is activated
            // Refresh the DataGridView when the form is activated
            LoadDataGrid();
        }


        #region processes
        private void LoadDataGrid()
        {
            DataModel dm = new DataModel();
            DataTable dt = dm.GetAllSubCategories();
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

            dataGridView1.Columns["sub_cat"].HeaderText = "Category";
            dataGridView1.Columns["sub_cat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["sub_cat"].Visible = true;
            dataGridView1.Columns["sub_cat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["sub_cat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns["notes"].HeaderText = "Description";
            dataGridView1.Columns["notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["notes"].Visible = true;

            dataGridView1.Columns["parent_id"].Visible = false;


        }

        private void doDelete()
        {
            DataModel dm = new DataModel();

            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "delete");

            if (dm.DeleteSubCatById(selectedPdfId))
            {
                LoadDataGrid();
            }

        }

        private void doEdit()
        {
            DataGridViewRow selectedRow = mic.GetSelectedGridRow(dataGridView1, "modify");
            if (selectedRow == null)
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                SubCatForm scf = new SubCatForm(selectedRow, true);
                scf.ShowDialog();
                this.LoadDataGrid();
            }

        }

        #endregion

        #region controls
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subcatButton_Click(object sender, EventArgs e)
        {
            // Cast the sender back to a Button
            Button btn = (Button)sender;

            // Show the context menu directly below the bottom-left corner of the button
            contextMenuStrip1.Show(btn, new Point(0, btn.Height));

        }
        #endregion

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubCatForm scf = new SubCatForm(false);
            scf.ShowDialog();
            LoadDataGrid();
                            
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCatForm scf = new SubCatForm(false);
            scf.ShowDialog();
            LoadDataGrid();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doEdit();

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doEdit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDelete();

        }
        private void delteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDelete();
        }
    }
}
