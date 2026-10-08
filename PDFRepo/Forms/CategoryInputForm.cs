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
        private bool isEditMode = false;
        public CategoryInputForm()
        {
            InitializeComponent();
        }

        public CategoryInputForm(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            isEditMode= true; // Set the flag to indicate edit mode
            LoadForm();

        }
        private void LoadForm()
        {
           
            this.categoryTextBox.Text = selectedRow.Cells["category"].Value.ToString();
            this.notesTextbox.Text = selectedRow.Cells["notes"].Value?.ToString();
        }


        #region addNewCategory
        private void saveButton_Click(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            if (dm.addCategory(categoryTextBox.Text, notesTextbox.Text ))
            {
                MessageBox.Show("Category added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add category.");
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
