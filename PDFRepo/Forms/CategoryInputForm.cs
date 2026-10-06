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
    public partial class CategoryInputForm : Form
    {
        public CategoryInputForm()
        {
            InitializeComponent();
        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
