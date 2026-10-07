using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PDFRepo.DataClasses;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.Forms
{
    public partial class PDFInfoForm : Form
    {
        private string selectableCategoryId;
        private string selectableCategory;
        private DataModel dm = null;
        public PDFInfoForm(string pdfId)
        {
            dm = new DataModel();
            InitializeComponent();
            categoryComboBox.SelectionChangeCommitted += categoryComboBox_SelectionChangeCommitted;
            LoadFormData(pdfId);
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            categoryComboBox.DataBindings["SelectedValue"]?.WriteValue();
        }

        private void LoadFormData(string pdfId)
        {
            LoadComboBox();
            idTextBox.Text = pdfId;
            DataModel dm = new DataModel();
            DataTable dt = dm.GetPDFInfo(pdfId);

            fnameTextBox.Text = dt.Rows[0]["pdf_name"].ToString();
            descriptionTextBox.Text = dt.Rows[0]["pdf_description"].ToString();
            categoryComboBox.Text = dt.Rows[0]["pdf_category"].ToString();
            creationDateTextBox.Text = dt.Rows[0]["pdf_created"].ToString();
            fileSizeTextBox.Text = dt.Rows[0]["pdf_size"].ToString();
            attributeTextBox.Text = dt.Rows[0]["pdf_attributes"].ToString();
            lastModextBox.Text = dt.Rows[0]["pdf_lastmod"].ToString();

        }

        private string[] GetIngredientList()
        {
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
            string[] items = GetIngredientList();

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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string ingredientStr = categoryComboBox.Text.Trim();
            this.selectableCategoryId = dm.GetCategoryIdByName(categoryStr).ToString();
            categoryComboBox.Text = this.dm.GetCategoryById(this.selectableCategoryId);
            categoryCombo.Text = categoryComboBox.Text.Trim();
            categoryKeyTextBox.Text = this.selectableCategory;
            */
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
            bool success = dm.UpdatePDFInfo(idTextBox.Text, categoryComboBox.Text, descriptionTextBox.Text);
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
    }
}
