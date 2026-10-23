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
        public ConfigMgr configuration;
        public ConfigElements config;
        private string backupPath = string.Empty;

        public BackupForm(Program program)
        {
            InitializeComponent();
            logger = new LogClass();
            configuration = new ConfigMgr(program);
            config = configuration.GetCfg();

        }

        #region processing

        private void setBackupPath()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Optional configuration
                folderDialog.Description = "Select PDFRepo Backup Folder";
                folderDialog.UseDescriptionForTitle = true; // Shows the description as the dialog title on Windows 11
                folderDialog.ShowNewFolderButton = true;    // Allows the user to create a new folder

                // Set a starting directory (e.g., the user's Documents folder)
                folderDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Show the dialog and check if the user clicked "OK"
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected path
                    string selectedFolderPath = folderDialog.SelectedPath;

                    // Display or use the folder path
                    bkupPathTextBox.Text = selectedFolderPath;
                    //   MessageBox.Show($"Selected Folder: {selectedFolderPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //  return bkupPathTextBox.Text;
            }
        }

        // SaveOnJsonParm(string parm)
        private void doConfigUpdate()
        {
            if (string.IsNullOrWhiteSpace(bkupPathTextBox.Text))
            {
                MessageBox.Show("Please select a valid backup path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Save the backup path to application settings
            configuration.SaveOneJsonParm(bkupPathTextBox.Text);
            
            MessageBox.Show("Backup path saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            setBackupPath();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            doConfigUpdate();
            logger.LogPost("Changed and save backup path.");
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
