
#define DEBUG_MODE

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


        #region instanceVariables

        private bool _isResettingComboBoxes = false;
        public ConfigMgr configMgr { get; set; }
        public ConfigElements config { get; set; }
        private LogClass logger;
        private MethodsInCommon mic;
        private bool firstTime = true;
        public Program program;

        public bool ShowAtStartup { get; set; }

        private string selectablePDFId = "-1";

        private string dbPath;
        private string selectedNameStr;
        //      private CreateDB cdb = null;
        #endregion

        #region constructor
        public PDF_list(Program program)
        {
            // Store the reference to the Program instance, so we can access some properties and methods globally.
            this.program = program; 

            InitializeComponent();
            WireUpHandlers();
            ConfigureApplication();

            BuildComboBoxes();  
        }
        #endregion

        #region initialization
        /// <summary>
        /// Initializes and populates the category, subcategory, and selector combo boxes with auto-complete data.
        /// </summary>
        /// <remarks>Creates data access and dropdown helper instances, then binds each combo box to its
        /// corresponding table using the display column and ID value column.</remarks>
        private void BuildComboBoxes()
        {
            DataModel dm = new DataModel();
            DropDown dd = new DropDown(dm);

            dd.LoadAutoCompleteComboBox(dm, categoryComboBox, "pdf_cat", "category", "ID");
            dd.LoadAutoCompleteComboBox(dm, subCatComboBox, "sub_category", "sub_cat", "ID");
            dd.LoadAutoCompleteComboBox(dm, selectorComboBox, "pdf_table", "pdf_name", "ID");
        }   

        private void ConfigureApplication()
        {
            // 1. Create the database if it doesn't exist
            CreateDbIFNotExists();
            // 2. Load the configuration settings
            SetupConfig();
            // 3. Initialize common methods utility
            mic = new MethodsInCommon();
            // 4. Set the user name in the UI
            userNameTextBox.Text = $"{config.firstName} {config.lastName}".Trim();
            // 5. Set global bypass on startup variable in _program
            program.bypassOnStartup = Convert.ToBoolean(this.config.bypassOnStartup); 
            // 6. Based on result, show splash screen
            DoSplashScreenIfNeeded();
            // 7. Create log file if it doesn't exist
            CreateLogger();

        }

        private void CreateLogger()
        {

            logger = new LogClass();
            logger.LogPost("Started PDFRepo.");
        }

        private void DoSplashScreenIfNeeded()
        {
            if (!program.bypassOnStartup)
            {
                SplashScreen splash = new SplashScreen(this.program, configMgr, config, userNameTextBox.Text);
                splash.ShowDialog();
            }
        }       

        private void CreateDbIFNotExists()
        {
            CreateDB cdb = new CreateDB(program);
            this.dbPath =cdb.CreateDatabase();
        }

        private void SetupConfig()
        {
            ConfigElements Localconfig;
            configMgr = new ConfigMgr(program);
            Localconfig = configMgr.GetCfg();
            this.config = Localconfig;
        }

        #endregion

        #region handlers  // *********************** All in-house handlers live here!  ***********************

        /// <summary>
        /// Commits the combo box's current selected value to its <c>SelectedValue</c> data binding.
        /// </summary>
        /// <remarks>Triggered when a selection change is committed by the user.</remarks>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">An <see cref="EventArgs" /> instance containing the event data.</param>
        private void selectorComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            selectorComboBox.DataBindings["SelectedValue"]?.WriteValue();

        }

        /// <summary>
        /// Handles the selector combo box selection change by resolving the selected PDF identifier, displaying the
        /// PDF, and resetting form selection state.
        /// </summary>
        /// <remarks>Returns without action when the combo box is being reset or when no item is
        /// selected.</remarks>
        /// <param name="sender">The ComboBox that raised the event.</param>
        /// <param name="e">Event data for the selection change.</param>

        private void selectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isResettingComboBoxes) return;
            if (selectorComboBox.SelectedIndex == -1) return;

            string selectedNameStr = selectorComboBox.Text;
            DataModel dm = new DataModel();
            this.selectablePDFId = dm.GetPdfIdByName(selectedNameStr);
            doViewPDF(selectablePDFId); // As a string, this.selectablePDFId can be used to fetch the PDF data from the database and display it in a new form.
            ResetFormSelection();

        }

        /// <summary>
        /// Paints a 1-based row number in the row header after a DataGridView row is rendered.
        /// </summary>
        /// <remarks>Uses the row header foreground color from RowHeadersDefaultCellStyle, with a fallback
        /// to SystemColors.ControlText when the configured color is empty or transparent.</remarks>
        /// <param name="sender">The DataGridView that raised the RowPostPaint event.</param>
        /// <param name="e">Provides the graphics surface, row bounds, and row index used to draw the row header content.</param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string lineNumber = (e.RowIndex + 1).ToString();

            StringFormat centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dataGridView1.RowHeadersWidth,
                e.RowBounds.Height
            );

            // FIX: Access ForeColor safely via the RowHeadersDefaultCellStyle object
            Color headerColor = dataGridView1.RowHeadersDefaultCellStyle.ForeColor;

            // Fallback safeguard: If the default color is empty or transparent, default to ControlText
            if (headerColor.IsEmpty || headerColor == Color.Transparent)
            {
                headerColor = SystemColors.ControlText;
            }

            using (Brush brush = new SolidBrush(headerColor))
            {
                e.Graphics.DrawString(
                    lineNumber,
                    dataGridView1.Font,
                    brush,
                    headerBounds,
                    centerFormat
                );
            }
        }


        /// <summary>
        /// Refreshes the PDF list data when the list is activated.
        /// </summary>
        /// <param name="sender">Object that raised the activation event.</param>
        /// <param name="e">Event data for the activation event.</param>
        /// 

        // we are born agin right here
        private void PDF_list_Activated(object sender, EventArgs e)
        {

       //     if (selectorComboBox.SelectedIndex == -1) return;

            LoadDataGrid();

            BuildComboBoxes();


        }
        /// <summary>
        /// Display a selected PDF for the user.
        /// Handles cell click events in the grid and opens the selected PDF when the clicked cell is in the "pdf_name"
        /// column of a valid data row. 
        /// </summary>
        /// <remarks>Clicks outside valid row or column bounds, including header cells, are
        /// ignored.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the clicked cell, including row and column indexes.</param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  if (_isResettingGeneric) return;
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



        #endregion   // ***************** end In-house handlers ****************

        #region handler helpers


        private void WireUpHandlers()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            selectorComboBox.SelectionChangeCommitted += selectorComboBox_SelectionChangeCommitted;

            // Wire the event handler to myDataGridView
            dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
        }

        private void ResetFormSelection()
        {
            // 4. Raise the shield, clear the index, drop the shield
            _isResettingComboBoxes = true;

            selectorComboBox.SelectedIndex = -1;
            selectorComboBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = -1;
            categoryComboBox.Text = string.Empty;
            subCatComboBox.SelectedIndex = -1;
            subCatComboBox.Text = string.Empty;


            _isResettingComboBoxes = false;
        }

        #endregion

        #region controlHelpers
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
            pdfCountTextBox.Text = dt.Rows.Count.ToString();
        }

        private void FormatDataGrid()
        {

            // Set an initial comfortable width for the row numbers
            dataGridView1.RowHeadersWidth = 50;

            // Prevent the grid from forcing users to manually resize the header column
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;


            // Define the default style for all rows (e.g., even rows)
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Define the style for alternating rows (e.g., odd rows)
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;


            dataGridView1.Columns["ID"].HeaderText = "Primary Key-ID";
#if DEBUG_MODE
            dataGridView1.Columns["ID"].Visible = true;
#else
            dataGridView1.Columns["ID"].Visible = false;
#endif
            dataGridView1.Columns["ID"].Width = 72;


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

            PreventSorting();  // Call the method to prevent sorting on all columns

        }

        private void PreventSorting()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }   

        /// <summary>
        /// Deletes the selected PDF record and refreshes the grid when the deletion succeeds.
        /// </summary>
        /// <remarks>Returns without changes when no valid row is selected. Shows a success or failure
        /// message based on the delete operation result.</remarks>
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
                viewPdfForm.Show();
                ResetFormSelection();
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
            BackupForm backupForm = new BackupForm(program);
            backupForm.Show();
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
                viewPdfForm.Show();
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
        //    FormatDataGrid();
        //    ResetFormSelection();

        }
        private void subCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            DataTable selectedRecords = dm.getRecordsSubCategory(categoryComboBox.Text, subCatComboBox.Text);
            dataGridView1.DataSource = selectedRecords;
        //    FormatDataGrid();
        //    ResetFormSelection();
        }


        private void showAllButton_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            FormatDataGrid();
            ResetFormSelection();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isResettingComboBoxes = true; // Raise the shield to prevent unwanted event triggers during form operations
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            //   BuildComboBox(); -- This line is commented out because the ComboBox will be rebuilt when
            //   the form is activated, so it is not necessary to call BuildComboBox() here.

        }



        private void editSubCatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    _isResettingComboBoxes = true; // Raise the shield to prevent unwanted event triggers during form operations
            SubCatGridForm scf = new SubCatGridForm();
            scf.Show();
        }

        private void subCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
      //      _isResettingComboBoxes = true; // Raise the shield to prevent unwanted event triggers during form operations
            SubCatGridForm scf = new SubCatGridForm();
            scf.Show();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm sf = new SetupForm(program, configMgr, config);
            sf.ShowDialog();
            userNameTextBox.Text = $"{configMgr.GetCfg().firstName} {configMgr.GetCfg().lastName}";
        }

        private void PDF_list_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
