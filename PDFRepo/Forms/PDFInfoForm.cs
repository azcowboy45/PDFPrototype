using PDFRepo.DataClasses;
using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PDFRepo.utils;

namespace PDFRepo.Forms
{
    public partial class PDFInfoForm : Form
    {
        private string selectableCategoryId;
        private string selectableCategory;
        private DataModel dm = null;
        private MethodsInCommon mic;

        public PDFInfoForm(string pdfId)
        {
            dm = new DataModel();
            mic = new MethodsInCommon();
            InitializeComponent();
            LoadFormData(pdfId);
            // Wire up the Activated event handler programmatically
            this.Activated += PDFList_Activated;  // Wire up the Activated event handler programmatically to the PDF_List form.

        }

        private void PDFList_Activated(object sender, EventArgs e)
        {
            BuildComboBoxes();  // Rebuild the ComboBox when the form is activated
                                // Refresh the DataGridView when the form is activated
                                // LoadDataGrid();
        }


        private void LoadFormData(string pdfId)
        {
            BuildComboBoxes();
            idTextBox.Text = pdfId;
            DataModel dm = new DataModel();
            DataTable dt = dm.GetPDFInfo(pdfId);

            fnameTextBox.Text = dt.Rows[0]["pdf_name"].ToString();
            descriptionTextBox.Text = dt.Rows[0]["pdf_description"].ToString();

            categoryComboBox.Text = dt.Rows[0]["pdf_category"].ToString();
            attributeTextBox.Text = dt.Rows[0]["pdf_attributes"].ToString();
            creationDateTextBox.Text = dt.Rows[0]["pdf_created"].ToString();
            fileSizeTextBox.Text = dt.Rows[0]["pdf_size"].ToString();
            lastModextBox.Text = dt.Rows[0]["pdf_lastmod"].ToString();
            categoryTextBox.Text = dt.Rows[0]["pdf_category"].ToString();
            subcategoryTextBox.Text = dt.Rows[0]["pdf_subcat"].ToString();



            // And now load the scomboboxes based on the selected data
          //  string category = dt.Rows[0]["pdf_category"].ToString().Trim();
          //  categoryComboBox.SelectedValue = category;
            

           // string subCategory = dt.Rows[0]["pdf_subcat"].ToString().Trim();
          //  subCatComboBox.SelectedValue = subCategory;

        }



        private void BuildComboBoxes()
        {
            DataModel dm = new DataModel();
            DropDown dd = new DropDown(dm);
            dd.LoadComboBox(categoryComboBox, true);
            dd.LoadComboBox(subCatComboBox, false);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            bool success = dm.UpdatePDFInfo(idTextBox.Text, categoryComboBox.Text, subCatComboBox.Text, descriptionTextBox.Text);
            if (success)
            {
                MessageBox.Show("PDF information updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update PDF information.");
            }
        }

        private void editCatButton_Click(object sender, EventArgs e)
        {
            CategoryGridForm cf = new CategoryGridForm();
            cf.Show();
            BuildComboBoxes();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
