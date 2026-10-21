using PDFRepo.DataClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PDFRepo.utils
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
        private DataModel dm;
        public DropDown(DataModel dm)
        {
            this.dm = dm;
        }



        /**
         * This method is to load the selection box at the top of the PDF_List form.
         * REF  GetSelectorKeyedList(string tableName, String keyCol, String theId)
         * 
         * */
        public void LoadAutoCompleteComboBox(DataModel dm, ComboBox genericComboBox, string tableName, string keyCol, string theId)
        {
            string[] items = GetSelectionList(dm, tableName, keyCol, theId);

            // Create an AutoCompleteStringCollection and add the items
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            coll.AddRange(items);
            genericComboBox.Items.Clear();

            foreach (string item in items)
            {
                genericComboBox.Items.Add(item);
            }

            //    ingredientComboBox.Items.AddRange(items);   // this add the items again???

            // Set the AutoCompleteCustomSource to the collection created above
            genericComboBox.AutoCompleteCustomSource = coll;

            // Specify that the source for autocompletion is a custom source
            genericComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Set the mode to SuggestAppend (shows a dropdown list and appends matching text)
            genericComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Set the AutoCompleteCustomSource to the collection created above
            genericComboBox.AutoCompleteCustomSource = coll;
        }


            //   DataModel dm = new DataModel();
          // REF  GetSelectorKeyedList(string tableName, String keyCol, String theId)
        private string[] GetSelectionList(DataModel dm, string tableName, string keyCol, string theId)
        {
            string[] pdfList = new string[] { };

            DataSet autoList = dm.GetSelectorKeyedList(tableName, keyCol, theId);
            Int32 recCount = autoList.Tables[0].Rows.Count;

            foreach (DataRow row in autoList.Tables[tableName].Rows)
            {
                string str = row[0].ToString();
                pdfList = pdfList.Append<string>(str).ToArray();

            }
            return pdfList;
        }

         
        public void LoadComboBox(ComboBox genericCombobox, bool isCategory)
        {
            string[] items;
            if (isCategory)
            {
                items = GetCategoryList();
            }else
            {
                items = GetSubCatList();
            }


            // Create an AutoCompleteStringCollection and add the items
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            //    coll.AddRange(items);
            genericCombobox.Items.Clear();

            foreach (string item in items)
            {
                string trimmedItem = item.Trim();
                genericCombobox.Items.Add(trimmedItem);
            //    coll.Add(trimmedItem);
            }
            // Set the AutoCompleteCustomSource to the collection created above
            genericCombobox.AutoCompleteCustomSource = coll;
            // Specify that the source for autocompletion is a custom source
            genericCombobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // Set the mode to SuggestAppend (shows a dropdown list and appends matching text)
     //       genericCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // Set the AutoCompleteCustomSource to the collection created above
            genericCombobox.AutoCompleteCustomSource = coll;
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


        private string[] GetSubCatList()
        {
            string[] categoryList = new string[] { };
            DataTable autoList = dm.getCategoryKeyedList("sub_category", "sub_cat", "id");

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
