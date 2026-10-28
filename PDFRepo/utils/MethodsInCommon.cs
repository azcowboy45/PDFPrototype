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

        public string getFolderPath(string dlogTitle)
        {
            string selectedFolderPath = null;
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    // Optional: Set a starting directory or description
                    folderDialog.Description = dlogTitle;
                    folderDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    // Show the dialog and check if the user clicked OK
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        // This is the absolute path to the selected folder
                        string selectedPath = folderDialog.SelectedPath;

                        // Example: Display it in a TextBox
                        selectedFolderPath = selectedPath;
                    }
                }
                return selectedFolderPath;
            }
        }

        public string getFilePath(string dlogTitle, string fileFfilter)
        {
            string selectedFilePath = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                // 1. Target the absolute root of the user's home directory
                string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                // 2. Configure the dialog properties
                openFileDialog.InitialDirectory = homeDirectory;
                openFileDialog.Title = dlogTitle;

                // Forces the dialog to isolate and list only .pdf files 
                openFileDialog.Filter = fileFfilter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // 3. Display the dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // This string holds the full path to the chosen system file
                    selectedFilePath = openFileDialog.FileName;
                }
            }
            return selectedFilePath;
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
