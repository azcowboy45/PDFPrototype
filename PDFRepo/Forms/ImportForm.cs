using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDFRepo.DataClasses;

namespace PDFRepo.Forms
{
    public partial class ImportForm : Form
    {
        //   string selectedPdfPath = null;
        string fName = null;
        string fSize = null;
        string fCreated = null;
        string fLastmod = null;
        string fAttributes = null;
        byte[] pdfBytes = null;

        public ImportForm()
        {
            InitializeComponent();
       //     categoryComboBox.SelectionChangeCommitted += categoryComboBox_SelectionChangeCommitted;
            LoadComboBox();
        }


        private void ImportForm_Load(object sender, EventArgs e)
        {
          //  categoryComboBox.SelectionChangeCommitted += categoryComboBox_SelectionChangeCommitted
        }

        private string[] GetCategoryList()
        {
            DataModel dm = new DataModel();
            string[] ingredientList = new string[] { };
            DataTable autoList = dm.getCategoryKeyedList("pdf_cat", "category", "id");
            Int32 recCount = autoList.Rows.Count;

            foreach (DataRow row in autoList.Rows)
            {
                string str = row[0].ToString();
                ingredientList = ingredientList.Append<string>(str).ToArray();

            }

            return ingredientList;
        }

        private void LoadComboBox()
        {
            string[] items = GetCategoryList();

            // Create an AutoCompleteStringCollection and add the items
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            coll.AddRange(items);
            categoryComboBox.Items.Clear();

            foreach (string item in items)
            {
                categoryComboBox.Items.Add(item);
            }

            //    ingredientComboBox.Items.AddRange(items);   // this add the items again???

            // Set the AutoCompleteCustomSource to the collection created above
            categoryComboBox.AutoCompleteCustomSource = coll;

            // Specify that the source for autocompletion is a custom source
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Set the mode to SuggestAppend (shows a dropdown list and appends matching text)
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Set the AutoCompleteCustomSource to the collection created above
            categoryComboBox.AutoCompleteCustomSource = coll;
        }



        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryComboBox.DataBindings["SelectedValue"]?.WriteValue();
        }

        private string getPdfFile()
        {
            string selectedFilePath = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                // 1. Target the absolute root of the user's home directory
                string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                // 2. Configure the dialog properties
                openFileDialog.InitialDirectory = homeDirectory;
                openFileDialog.Title = "Find a PDF File for Import";

                // Forces the dialog to isolate and list only .pdf files 
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
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

        private void updateFileInfo(string pdfFilePath)
        {
            if (!string.IsNullOrEmpty(pdfFilePath))
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(pdfFilePath);
                fName = fileInfo.Name;
                fSize = fileInfo.Length.ToString();
                fCreated = fileInfo.CreationTime.ToString();
                fLastmod = fileInfo.LastWriteTime.ToString();
                fAttributes = fileInfo.Attributes.ToString();
                // Update the UI with the file information
                //fnameTextBox.Text = fName;
                fileSizeTextBox.Text = fSize;
                creationDateTextBox.Text = fCreated;
                lastModextBox.Text = fLastmod;
                attributeTextBox.Text = fAttributes;

                // Read the PDF file into a byte array
                pdfBytes = File.ReadAllBytes(pdfFilePath);
            }
        }

        private bool doImport(string pdfFilePath, string description, string category)
        {
            bool importSuccess = false;

        //    updateFileInfo(pdfPathTextBox.Text);

            if (pdfBytes != null && pdfBytes.Length > 0)
            {
                DataModel dm = new DataModel();
                importSuccess = dm.insertPDF(fName, pdfBytes, fCreated, fLastmod, fSize, fAttributes, description, category);
            }
            else
            {
                MessageBox.Show("Failed to read the PDF file. Please check the file and try again.");
            }


            return importSuccess;
        }

        #region controls

        private void selectPDFButton_Click(object sender, EventArgs e)
        {
            pdfPathTextBox.Text = getPdfFile();

            if (!string.IsNullOrEmpty(pdfPathTextBox.Text))
            {
                updateFileInfo(pdfPathTextBox.Text);
                importButton.Enabled = true;
            }
            else
            {
                importButton.Enabled = false;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string pdfFilePath = pdfPathTextBox.Text;
            string description = descriptionTextBox.Text;
            string category = categoryComboBox.Text;
            if (doImport(pdfFilePath, description, category))
            {
                MessageBox.Show("PDF imported successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to import PDF. Please check the details and try again.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
