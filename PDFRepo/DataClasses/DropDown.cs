using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PDFRepo.DataClasses
{

    /**
     * DropDown class is responsible for populating a ComboBox with category data retrieved from a DataModel.
     * It provides functionality to load the ComboBox with category items and set up auto-completion features.
     *  
     * The object from this class is best called via a handler fired from "this.Activated +=... " in the calling form.
     * 
     */
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
            string[] categoryList = new string[] { };
            DataTable autoList = dm.getCategoryKeyedList("pdf_cat", "category", "id");

            autoList.DefaultView.Sort = "KeyCol ASC"; // Sort the DataTable by the "KeyCol" column in ascending order

            autoList = autoList.DefaultView.ToTable();
            int recCount = autoList.Rows.Count;

            foreach (DataRow row in autoList.Rows)
            {
                string str = row[0].ToString();
                categoryList = categoryList.Append<string>(str).ToArray();

            }

            return categoryList;
        }





    }
}
