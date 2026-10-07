using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.DataClasses
{
    internal class DropDown
    {
        private DataModel dm = null;
        public DropDown(DataModel dm, ComboBox categoryComboBox)
        {
            this.dm = dm;
            LoadComboBox(categoryComboBox);
        }



        private void LoadComboBox(ComboBox categoryComboBox)
        {
            string[] items = GetCategoryList();

            // Create an AutoCompleteStringCollection and add the items
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            //    coll.AddRange(items);
            categoryComboBox.Items.Clear();

            foreach (string item in items)
            {
                categoryComboBox.Items.Add(item);
            }
            // Set the AutoCompleteCustomSource to the collection created above
            categoryComboBox.AutoCompleteCustomSource = coll;
            // Specify that the source for autocompletion is a custom source
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // Set the mode to SuggestAppend (shows a dropdown list and appends matching text)
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // Set the AutoCompleteCustomSource to the collection created above
            categoryComboBox.AutoCompleteCustomSource = coll;
        }

        private string[] GetCategoryList()
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





    }
}
