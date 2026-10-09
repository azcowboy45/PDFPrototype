using Microsoft.Data.Sqlite;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using PDFRepo.DataClasses;
using System.Data;
using PDFRepo.Forms;
using PDFRepo.utils;

namespace PDFRepo
{
    public partial class PDF_list : Form
    {
        //    private Config cfg;
        //    private StartForm loginForm;
        private DataTable configDataTable;
        private MethodsInCommon mic;

        bool onOne = true;
        public PDF_list()
        {
            mic = new MethodsInCommon();
            InitializeComponent();
        //    LoadDataGrid();
            // Wire up the Activated event handler programmatically
            this.Activated += PDFList_Activated;  // Wire up the Activated event handler programmatically to the PDF_List form.

            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;

            // Ensure the click is on a valid data row and targets the button column
            if (e.RowIndex >= 0 && e.ColumnIndex == grid.Columns["ViewPDF"].Index)
            {
                onOne = false;
                // Retrieve data from another column in the same row
                // 3. Ensure the click happened specifically on your button column
                if (e.ColumnIndex == grid.Columns["ViewPDF"].Index)
                {
                    // 4. Get the full row object using e.RowIndex
                    DataGridViewRow clickedRow = grid.Rows[e.RowIndex];

                    // 5. Access data from this specific row
                    string selectedPdfId = clickedRow.Cells["ID"].Value?.ToString();
                    doViewPDF(selectedPdfId);

                }
            }
        }

        private void PDFList_Activated(object sender, EventArgs e)
        {
            BuildComboBox();  // Rebuild the ComboBox when the form is activated
            // Refresh the DataGridView when the form is activated
            LoadDataGrid();
        }



        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "ViewPDF";
            buttonColumn.HeaderText = "View PDF";
            buttonColumn.Text = "View";
            // 2. CRITICAL: Tell the grid to actually draw this text on the buttons
            buttonColumn.UseColumnTextForButtonValue = true;

            // 3. Add the button column to the dynamically created grid
            dataGridView1.Columns.Add(buttonColumn);

            // 4. Wire up the click event handler
            //    dataGridView1.CellClick += dataGridView1_CellClick;

            // 5. Add the grid to your Form's controls so it appears on screen
            this.Controls.Add(dataGridView1);
        }



        private void BuildComboBox()
        {
            DataModel dm = new DataModel();
            DropDown dd = new DropDown(dm, categoryComboBox);
        }

        #region processingMethods
        private void LoadDataGrid()
        {
            DataModel dm = new DataModel();
            DataTable dt = dm.GetAllPDFs();
            dataGridView1.DataSource = dt;
            if (onOne)
            {
                AddButtonColumn();  // Add the button column after setting the DataSource
            }
            
            FormatDataGrid(); ;
        }

        private void FormatDataGrid()
        {

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            // Define the default style for all rows (e.g., even rows)
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Define the style for alternating rows (e.g., odd rows)
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID"].Visible = true;
            dataGridView1.Columns["ID"].Width = 64;

            dataGridView1.Columns["pdf_name"].HeaderText = "PDF Name";
            dataGridView1.Columns["pdf_name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_name"].Visible = true;
            dataGridView1.Columns["pdf_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["pdf_name"].Width = 256;

            dataGridView1.Columns["pdf_file"].Visible = false;  // This large binary crashes datagrid

            dataGridView1.Columns["pdf_created"].HeaderText = "Created";
            dataGridView1.Columns["pdf_created"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_created"].Visible = true;
            dataGridView1.Columns["pdf_created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["pdf_created"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["pdf_lastmod"].HeaderText = "Last Modified";
            dataGridView1.Columns["pdf_lastmod"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_lastmod"].Visible = true;
            dataGridView1.Columns["pdf_lastmod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["pdf_lastmod"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["pdf_size"].HeaderText = "Size";
            dataGridView1.Columns["pdf_size"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_size"].Visible = true;
            dataGridView1.Columns["pdf_size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns["pdf_size"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["pdf_size"].Width = 128;

            dataGridView1.Columns["pdf_category"].HeaderText = "Category";
            dataGridView1.Columns["pdf_category"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_category"].Visible = true;
            dataGridView1.Columns["pdf_category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["pdf_category"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dataGridView1.Columns["pdf_category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["pdf_description"].HeaderText = "Description";
            dataGridView1.Columns["pdf_description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["pdf_description"].Visible = true;


        }




        private void doDeletePDF()
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "delete");
            if (selectedPdfId == "-1")
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                DataModel dm = new DataModel();
                bool deleteSuccess = dm.DeletePDF(selectedPdfId);
                if (deleteSuccess)
                {
                    MessageBox.Show("PDF record deleted successfully.");
                    this.LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Failed to delete PDF record. Please try again.");
                }
            }
        }

        private void doViewPDF(string selectedPdfId )
        {
;
            if (selectedPdfId == "-1")
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                ViewPdfForm viewPdfForm = new ViewPdfForm(selectedPdfId);
                viewPdfForm.ShowDialog();
            }
        }


        #endregion

        #region controls        
        private void ViewButton_Click(object sender, EventArgs e)
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "view");
            doViewPDF(selectedPdfId);
        }

        private void viewPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "view");
            doViewPDF(selectedPdfId);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
            this.LoadDataGrid();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export functionality not yet implemented.");
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.ShowDialog();
        }

        private void modifyPDFRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "modify"); ;
            if (selectedPdfId == "-1")
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                PDFInfoForm pdfInfoForm = new PDFInfoForm(selectedPdfId);
                pdfInfoForm.ShowDialog();
                this.LoadDataGrid();
            }

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void modifyPDFInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "modify");
            if (selectedPdfId == "-1")
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                PDFInfoForm pdfInfoForm = new PDFInfoForm(selectedPdfId);
                pdfInfoForm.ShowDialog();
                this.LoadDataGrid();
            }
        }
        private void viewPDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string selectedPdfId = mic.GetSelectedGridRowId(dataGridView1, "view");
            if (selectedPdfId == "-1")
            {
                return; // Exit the method if no valid ID was selected
            }
            else
            {
                ViewPdfForm viewPdfForm = new ViewPdfForm(selectedPdfId);
                viewPdfForm.ShowDialog();
                this.LoadDataGrid();
            }

        }

        private void pdfImportButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
            this.LoadDataGrid();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDeletePDF();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doDeletePDF();
        }


        private void maintainCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            //   BuildComboBox(); -- This line is commented out because the ComboBox will be rebuilt when
            //   the form is activated, so it is not necessary to call BuildComboBox() here.
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            DataTable selectedRecords = dm.getRecordsCategory(categoryComboBox.Text);
            dataGridView1.DataSource = selectedRecords;
            FormatDataGrid();

        }

        #endregion

        private void showAllButton_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            FormatDataGrid();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            //   BuildComboBox(); -- This line is commented out because the ComboBox will be rebuilt when
            //   the form is activated, so it is not necessary to call BuildComboBox() here.

        }
    }
}
