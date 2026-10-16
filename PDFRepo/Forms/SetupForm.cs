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
        public ConfigElements config;
        private LogClass logger;
        public Configuration configuration;
        private string pdfAppPath = string.Empty;
        public SetupForm(Configuration configuration, ConfigElements config)
        {
            this.configuration = configuration;
            this.config = config;
            this.configuration = configuration;
            logger = new LogClass();
            InitializeComponent();
            LoadSettingsForm();
        }

        /*
            string firstName, 
            string lastName, 
            string dbPath, 
            string bkupPath, 
            string enableLogging, 
            string bypassOnStartup)
        */
        public void doUpdate()
        {
            configuration.UpdateJsonConfig(
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                dbPathTextBox.Text,
                bkupPathTextBox.Text,
                enableLoggingCheckBox.Checked.ToString(),
                bypassOnStartupCheckBox.Checked.ToString());
        }
        private void LoadSettingsForm()
        {
            firstNameTextBox.Text = config.firstName;
            lastNameTextBox.Text = config.lastName;
            dbPathTextBox.Text = config.dbPath;
            bkupPathTextBox.Text = config.bkupPath;
            enableLoggingCheckBox.Checked = bool.TryParse(config.enableLogging, out bool enableLogging) && enableLogging;
            bypassOnStartupCheckBox.Checked = bool.TryParse(config.bypassOnStartup, out bool bypassOnStartup) && bypassOnStartup;
        }
        private void GatherSettings()
        {
            config.firstName = firstNameTextBox.Text;
            config.lastName = lastNameTextBox.Text;
            config.dbPath = dbPathTextBox.Text;
            config.bkupPath = bkupPathTextBox.Text;
            config.enableLogging = enableLoggingCheckBox.Checked.ToString();
            config.bypassOnStartup = bypassOnStartupCheckBox.Checked.ToString();
        }

        private void LogPost(string logEntry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            logger.AppendLogLine($"[{timestamp}] {logEntry}");
        }


        #region controls
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LogPost("Exited SetupForm, settings not saved.");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            doUpdate();

            LogPost("Saved settings from SetupForm");
            this.Close();
        }
        #endregion
    }
}
