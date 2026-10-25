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

        /// <summary>
        /// Adds a new category using the entered category name and notes, then reports the result to the user.
        /// </summary>
        /// <remarks>Normalizes the category name to lowercase before saving. Closes the current form when
        /// the category is added successfully.</remarks>
        private void AddCategory()
        {
            DataModel dm = new DataModel();
            string category = categoryTextBox.Text.ToLower();
            if (dm.addCategory(category, notesTextbox.Text))
            {
                MessageBox.Show("Category added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }
        }
     
        /// <summary>
        /// Updates the selected category using the current form values and closes the form when the update succeeds.
        /// </summary>
        /// <remarks>Converts the category text to lowercase before updating and displays a status message
        /// indicating success or failure.</remarks>
        private void UpdateCategory()
        {  
            string categoryId = selectedRow.Cells["ID"].Value.ToString();
            string category = categoryTextBox.Text.ToLower();

            DataModel dm = new DataModel();
       
            if (dm.UpdatePDFCat(categoryId, category, notesTextbox.Text))
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
