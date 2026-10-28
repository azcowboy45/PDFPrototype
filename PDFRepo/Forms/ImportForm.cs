using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using PDFRepo.DataClasses;
using PDFRepo.utils;

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
            BuildComboBoxes();
            AddToolTips();
        }
        private void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(selectPDFButton, "Click to select a PDF file for import.");
            toolTip.SetToolTip(pdfPathTextBox, "Displays the path of the selected PDF file.");
            toolTip.SetToolTip(descriptionTextBox, "Enter a description for the PDF file.");
            toolTip.SetToolTip(categoryComboBox, "Select a category for the PDF file.");
            toolTip.SetToolTip(subCatComboBox, "Select a subcategory for the PDF file.");
            toolTip.SetToolTip(importButton, "Click to import the selected PDF file into the database.");
            toolTip.SetToolTip(editCatButton, "Click to edit categories.");
            toolTip.SetToolTip(editSubcategoriesButton, "Click to edit subcategories.");
            toolTip.SetToolTip(exitButton, "Click to exit the import form.");
        }       
    

        private void BuildComboBoxes()
        {
            DataModel dm = new DataModel();
            DropDown dd = new DropDown(dm);
            dd.LoadComboBox(categoryComboBox, true);
            dd.LoadComboBox(subCatComboBox, false);
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryComboBox.DataBindings["SelectedValue"]?.WriteValue();
        }

        private string getPdfFilePath()
        {
            MethodsInCommon mic = new MethodsInCommon();
            string selectedFilePath = mic.getFilePath("Find a PDF File for Import", "PDF Files (*.pdf)|*.pdf");
  
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

        private bool doImport(string pdfFilePath, string description, string category, string subCategory)
        {
            bool importSuccess = false;

            //    updateFileInfo(pdfPathTextBox.Text);

            if (pdfBytes != null && pdfBytes.Length > 0)
            {
                DataModel dm = new DataModel();
                importSuccess = dm.insertPDF(fName, pdfBytes, fCreated, fLastmod, fSize, fAttributes, description, category, subCategory);
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
            pdfPathTextBox.Text = getPdfFilePath();

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
            string subCategory = subCatComboBox.Text;
            if (doImport(pdfFilePath, description, category, subCategory))
            {
                MessageBox.Show("PDF imported successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to import PDF. Please check the details and try again.");
            }

        }



        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void editCatButton_Click(object sender, EventArgs e)
        {
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            
        }

        private void subCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void editSubcategoriesButton_Click(object sender, EventArgs e)
        {
            SubCatGridForm sgf = new SubCatGridForm();
            sgf.Show();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportForm_Activated(object sender, EventArgs e)
        {
            BuildComboBoxes();
        }
    }
}
