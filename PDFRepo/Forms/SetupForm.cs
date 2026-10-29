using PDFRepo.DataClasses;
using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PDFRepo.Forms
{
    public partial class SetupForm : Form
    {
        private SplashScreen myParent = null;
        public ConfigElements config;
        private LogClass logger;
        public ConfigMgr configuration;
        private string pdfAppPath = string.Empty;
        public Program program;

        public SetupForm(Program program, ConfigMgr configuration, ConfigElements config)
        {
            this.program = program;
            this.configuration = configuration;
            this.config = config;
            logger = new LogClass();

            InitializeComponent();
            LoadSettingsForm();
        }
        public SetupForm(Program program, ConfigMgr configuration, ConfigElements config, SplashScreen myParent)
        {
            this.program = program;
            this.configuration = configuration;
            this.config = config;
            logger = new LogClass();
            InitializeComponent();
            LoadSettingsForm();
            this.myParent = myParent;
        }
        /**
         * Updates the configuration settings based on the values entered in the form.
         */
        public void doUpdate()
        {
            configuration.UpdateJsonConfig(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    pdfPathTextBox.Text,
                    dbPathTextBox.Text,
                    bkupPathTextBox.Text,
                    enableLoggingCheckBox.Checked.ToString(),
                    bypassOnStartupCheckBox.Checked.ToString(),
                    showLineNumbersCheckBox.Checked.ToString(),
                    bkupPathTextBox.Text
                );
        }
        /**
          * 
         * Loads the current configuration settings into the form controls.
         */
        private void LoadSettingsForm()
        {
            firstNameTextBox.Text = config.firstName;
            lastNameTextBox.Text = config.lastName;
            pdfPathTextBox.Text = config.PdfSearchPath;
            dbPathTextBox.Text = config.dbPath;
            bkupPathTextBox.Text = config.bkupPath;
            enableLoggingCheckBox.Checked = bool.TryParse(config.enableLogging, out bool enableLogging) && enableLogging;
            showLineNumbersCheckBox.Checked = bool.TryParse(config.showLineNumbers, out bool showLineNumbers) && showLineNumbers;
            bypassOnStartupCheckBox.Checked = bool.TryParse(config.bypassOnStartup, out bool bypassOnStartup) && bypassOnStartup;

            AddToolTips();


        }

        private void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(firstNameTextBox, "Enter your first name.");
            toolTip.SetToolTip(lastNameTextBox, "Enter your last name.");
            toolTip.SetToolTip(pdfPathTextBox, "Override search path for PDF files.");
            toolTip.SetToolTip(dbPathTextBox, "Enter the path to the database file.");
            toolTip.SetToolTip(bkupPathTextBox, "Enter the path to the backup directory.");
            toolTip.SetToolTip(enableLoggingCheckBox, "Check to enable logging.");
            toolTip.SetToolTip(bypassOnStartupCheckBox, "Check to bypass this setup form on startup.");
            toolTip.SetToolTip(showLineNumbersCheckBox, "Check to show line numbers in the PDF list view.");
        }

        private void LogPost(string logEntry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            logger.LogPost(logEntry);
        }

        private void CloseMyParentForm()
        {
            if (myParent != null)
            {
                myParent.Close();
            }
        }


        #region controls
        private void exitButton_Click(object sender, EventArgs e)
        {
            CloseMyParentForm();
            LogPost("Exited SetupForm, settings not saved.");
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            doUpdate();
            CloseMyParentForm();
            LogPost("Saved settings from SetupForm");
            this.Close();
        }


        private void enableLoggingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void bypassOnStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SetupForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void alterBackupPathButton_Click(object sender, EventArgs e)
        {
            MethodsInCommon mic = new MethodsInCommon();
            string selectedPath = mic.getFolderPath("Select Backup Directory");
            if (!string.IsNullOrEmpty(selectedPath))
            {
                bkupPathTextBox.Text = selectedPath;
            }
            else
            {
                MessageBox.Show("No folder selected. Please select a valid backup directory.");
            }
        }

        private void pdfPathButton_Click(object sender, EventArgs e)
        {
            MethodsInCommon mic = new MethodsInCommon();
            string selectedPath = mic.getFolderPath("Select PDF Directory");
            if (!string.IsNullOrEmpty(selectedPath))
            {
                pdfPathTextBox.Text = selectedPath;
            }
            else
            {
                MessageBox.Show("No folder selected. Please select a valid PDF directory.");
            }
        }
    }
}
