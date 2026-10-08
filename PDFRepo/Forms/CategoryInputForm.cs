using PDFRepo.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.Forms
{
    public partial class CategoryInputForm : Form
    {
        private DataGridViewRow selectedRow;
        private bool isEditMode;
        public CategoryInputForm(bool isEditMode)
        {
            InitializeComponent();
        }

        public CategoryInputForm(DataGridViewRow selectedRow, bool isEditMode)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.isEditMode= isEditMode; // Set the flag to indicate edit mode
            LoadForm();

        }
        private void LoadForm()
        {
           
            this.categoryTextBox.Text = selectedRow.Cells["category"].Value.ToString();
            this.notesTextbox.Text = selectedRow.Cells["notes"].Value?.ToString();
        }

        #region categoryWrites
        private void AddCategory()
        {
            DataModel dm = new DataModel();
            if (dm.addCategory(categoryTextBox.Text, notesTextbox.Text))
            {
                MessageBox.Show("Category added successfully.");
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
            if (dm.UpdatePDFCat(categoryId, categoryTextBox.Text, notesTextbox.Text))
            {
                MessageBox.Show("Category updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update category.");
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                UpdateCategory();

            }
            else
            {
                AddCategory();
            }
        }

        #endregion

        #region controls
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
