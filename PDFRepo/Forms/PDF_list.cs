using Microsoft.Data.Sqlite;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using PDFRepo.DataClasses;
using PDFRepo.Forms;
using PDFRepo.utils;
using System.ComponentModel;
using System.Data;

namespace PDFRepo
{
    public partial class PDF_list : Form
    {
        //    private Config cfg;
        //    private StartForm loginForm;

        // 2. Add this attribute to hide it from the UI Designer serialization
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        #region instance variables
        public ConfigMgr configMgr { get; set; }
        public ConfigElements config { get; set; }
        private MethodsInCommon mic;
        private bool firstTime = true;
        private Program _program;

        public bool ShowAtStartup { get; set; }

        private string selectablePDFId = "-1";
        private string selectedNameStr;
        #endregion

        public PDF_list(Program programReference)
        {
            configMgr = new ConfigMgr();
            _program = programReference;
            //   MessageBox.Show($"ShowAtStartup is now: {_program.showAtStartup}");  -- for debugging purposes
            mic = new MethodsInCommon();
            InitializeComponent();

            WireUpHandlers();

            configMgr = new ConfigMgr();
            config = configMgr.GetCfg();
            userNameTextBox.Text = $"{config.firstName} {config.lastName}".Trim();
            if (_program.showAtStartup)
            {
                doSplashScreen(userNameTextBox.Text);
            }
            LoadSelectionComboBox();
        }

        private void WireUpHandlers()
        {
            this.Activated += PDFList_Activated;
            dataGridView1.CellClick += dataGridView1_CellClick;
            selectorComboBox.SelectionChangeCommitted += selectorComboBox_SelectionChangeCommitted;
        }

        private void selectorComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectorComboBox.DataBindings["SelectedValue"]?.WriteValue();
        }

        private string[] GetSelectionList()
        {
            string[] pdfList = new string[] { };
            DataModel dm = new DataModel();
            DataSet autoList = dm.GetSelectorKeyedList("pdf_table", "pdf_name", "ID");
            Int32 recCount = autoList.Tables[0].Rows.Count;

            foreach (DataRow row in autoList.Tables["pdf_table"].Rows)
            {
                string str = row[0].ToString();
                pdfList = pdfList.Append<string>(str).ToArray();

            }
            return pdfList;
        }

        private void LoadSelectionComboBox()
        {
            string[] items = GetSelectionList();

            // Create an AutoCompleteStringCollection and add the items
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            coll.AddRange(items);
            selectorComboBox.Items.Clear();

            foreach (string item in items)
            {
                selectorComboBox.Items.Add(item);
            }

            //    ingredientComboBox.Items.AddRange(items);   // this add the items again???

            // Set the AutoCompleteCustomSource to the collection created above
            selectorComboBox.AutoCompleteCustomSource = coll;

            // Specify that the source for autocompletion is a custom source
            selectorComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Set the mode to SuggestAppend (shows a dropdown list and appends matching text)
            selectorComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Set the AutoCompleteCustomSource to the collection created above
            selectorComboBox.AutoCompleteCustomSource = coll;
        }

        private void selectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNameStr = selectorComboBox.Text;
            DataModel dm = new DataModel();

            this.selectablePDFId = dm.GetPdfIdByName(selectedNameStr);

            doViewPDF(selectablePDFId); // As a string, this.selectablePDFId can be used to fetch the PDF data from the database and display it in a new form.
        }

        private void doSplashScreen(string userName)
        {
            SplashScreen splash = new SplashScreen(configMgr, config, userName);
            splash.ShowDialog();
        }

        #region handlers

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Boundary Check: Prevent index out of range errors
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                // 1. Ensure the user clicked a valid data row, not the column header (Index -1)
                if (e.RowIndex >= 0)
                {
                    string clickedColumnName = dataGridView1.Columns[e.ColumnIndex].Name;
                    // Optional: Check if they clicked a specific column (e.g., Column index 2)
                    if (clickedColumnName == "pdf_name")
                    {
                        // 2. Fetch data from the clicked row to pass to your new form
                        string selectedItemId = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                        string selectedItemName = dataGridView1.Rows[e.RowIndex].Cells["pdf_name"].Value.ToString();
                        doViewPDF(selectedItemId);
                    }
                }
            }
        }

        private void PDFList_Activated(object sender, EventArgs e)
        {
            BuildComboBox();  // Rebuild the ComboBox when the form is activated
            // Refresh the DataGridView when the form is activated
            LoadDataGrid();
        }

        #endregion

        // This method builds the ComboBox for categories and subcategories
        private void BuildComboBox()
        {
            DataModel dm = new DataModel();
            DropDown dd = new DropDown(dm);
            dd.LoadComboBox(categoryComboBox, true);
            dd.LoadComboBox(subCatComboBox, false);
        }

        #region processingMethods
        private void LoadDataGrid()
        {
            DataModel dm = new DataModel();
            DataTable dt = dm.GetAllPDFs();
            dataGridView1.DataSource = dt;
            if (firstTime)
            {
                FormatDataGrid();
                firstTime = false;
            }
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
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["ID"].Width = 64;

            dataGridView1.Columns["pdf_name"].HeaderText = "Click on PDF Name to View";
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

            dataGridView1.Columns["pdf_subcat"].HeaderText = "Sub Category";
            dataGridView1.Columns["pdf_subcat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_subcat"].Visible = true;
            dataGridView1.Columns["pdf_subcat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["pdf_subcat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns["pdf_lastmod"].HeaderText = "Last Modified";
            dataGridView1.Columns["pdf_lastmod"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["pdf_lastmod"].Visible = false;
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
            dataGridView1.Columns["pdf_category"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


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

        private void doViewPDF(string selectedPdfId)
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
                clearSelections();
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





        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void doEdits()
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

        private void modifyPDFInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doEdits();
        }
        private void modifyPDFRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doEdits();
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





        private void subCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            DataTable selectedRecords = dm.getRecordsSubCategory(categoryComboBox.Text, subCatComboBox.Text);
            dataGridView1.DataSource = selectedRecords;
            FormatDataGrid();
        }

        private void clearSelections()
        {
            //  categoryComboBox.SelectedIndex = -1;
            //  subCatComboBox.SelectedIndex = -1;
            categoryComboBox.Text = "";
            subCatComboBox.Text = "";
        }


        private void showAllButton_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            FormatDataGrid();
            clearSelections();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            //   BuildComboBox(); -- This line is commented out because the ComboBox will be rebuilt when
            //   the form is activated, so it is not necessary to call BuildComboBox() here.

        }

        #endregion

        private void editSubCatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCatGridForm scf = new SubCatGridForm();
            scf.Show();
        }

        private void subCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCatGridForm scf = new SubCatGridForm();
            scf.Show();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm sf = new SetupForm(configMgr, config);
            sf.ShowDialog();
            userNameTextBox.Text = $"{configMgr.GetCfg().firstName} {configMgr.GetCfg().lastName}";
        }
/*
        private void selectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            DataModel dm = new DataModel();

            this.selectablePDFId = dm.GetPDFIdByName(this.selectedNameStr).ToString();

            doViewPDF(selectablePDFId); // As a string, this.selectablePDFId can be used to fetch the PDF data from the database and display it in a new form

        }

        */
    }
}
