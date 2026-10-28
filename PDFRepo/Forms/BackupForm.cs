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
    public partial class BackupForm : Form
    {


        private LogClass logger;
        public ConfigMgr configMgr { get; set; }
        public ConfigElements config { get; set; }


        /*
         * Available in the Program class:
                public bool bypassOnStartup { get; set; } = true;
                public string backupPath { get; set; } = string.Empty;
                public string settingsPath { get; set; } = string.Empty;
                public string dbPath { get; set; } = string.Empty;
         * */

        public BackupForm(Program program)
        {
            InitializeComponent();
            bkupPathTextBox.Text = program.backupPath;
        }

        #region processing
        private void doBackup()
        {
            // Implement the backup logic here
        }

        #endregion

        #region controls
        private void backupNowButton_Click(object sender, EventArgs e)
        {

        }

        private void restoreButton_Click(object sender, EventArgs e)
        {

        }

        private void modifyBkupPathButton_Click(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            doBackup();
            logger.LogPost("Backup complete.");
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
