using PDFRepo.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.Forms
{
    
    public partial class SubCatForm : Form
    {
        private bool isEditMode;
        private DataGridViewRow selectedRow;
        public SubCatForm(bool isEditMode)
        {
            InitializeComponent();
        }

        public SubCatForm(DataGridViewRow selectedRow, bool isEditMode)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.isEditMode = isEditMode; // Set the flag to indicate edit mode
            LoadForm();

        }

        private void LoadForm()
        {
            this.subCatTextBox.Text = selectedRow.Cells["sub_cat"].Value.ToString();
            this.notesTextBox.Text = selectedRow.Cells["notes"].Value?.ToString();
        }

        private void AddSubCategory()
        {
            DataModel dm = new DataModel();
            if (dm.AddSubCat(subCatTextBox.Text.ToLower(), notesTextBox.Text))
            {
                MessageBox.Show("Subcategory added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }
        }


        //UpdatePDFCat(string id, string pdfCategory, string catDescription)
        private void UpdateCategory()
        {
            DataModel dm = new DataModel();
            string categoryId = selectedRow.Cells["ID"].Value.ToString();
            string oldSubCat = selectedRow.Cells["sub_cat"].Value.ToString();
            string newSubCat = subCatTextBox.Text.ToLower();

            if (dm.UpdateSubCat(categoryId, oldSubCat, newSubCat, notesTextBox.Text))
            {
                MessageBox.Show("Category updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update category.");
            }
        }


        #region controls
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                UpdateCategory();

            }
            else
            {
                AddSubCategory();
            }
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form when the exit button is clicked
        }


        #endregion
    }
}
