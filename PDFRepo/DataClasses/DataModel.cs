#region usings
/*
 *   
  
 * Author: Bud Alexander, Copyright 2026 Spring Creek apps, All rights reserved.
 */

using Microsoft.Data.Sqlite;
// using Microsoft.Office.Interop.Excel;
using PDFRepo.DataClasses;
// using RecipieRepo.Utils;
//using RecipieRepo.Utils;
using SQLitePCL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


#endregion
namespace PDFRepo.DataClasses
{
    class DataModel
    {
        /**
         * The object from this class is best called via a handler fired from this.Actived in the calling form.
         * 
         * @param void 
         * @return void
         */
        #region instanceVariables
        //       private AppUtilities au;
        private string fname = "PDFRepo.db";
        private string bkupPath = "C:\\SQLiteBkup\\recipiesBkup.db";
        private string ConnectionString = "Data Source=C:\\PDFRepo\\PDFRepo.db;";

        // Maybe use this when deploying to a new machine. The database will be created in the same directory as the executable.
        //  private string ConnectionString = "Data Source=|DataDirectory|\\PDFRepo.db;";


        #endregion
        #region constructors

        #endregion


        #region sqliteMethods

        //GetAllSubCategories();
        public DataTable GetAllSubCategories()
        {
            DataTable dataTable = new DataTable();
            // Use 'using' statements to ensure connections and commands are properly disposed
            using (var connection = new SqliteConnection(ConnectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM sub_category;";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable = new DataTable();
                    dataTable.Load(reader); // Manually load from reader
                                            // Use your dataTable here
                }
            }
            return dataTable;
        }

        public DataTable GetAllCategories()
        {
            DataTable dataTable = new DataTable();
            // Use 'using' statements to ensure connections and commands are properly disposed
            using (var connection = new SqliteConnection(ConnectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM pdf_cat;";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable = new DataTable();
                    dataTable.Load(reader); // Manually load from reader
                                            // Use your dataTable here
                }
            }
            return dataTable;
        }


        public byte[] GetByteStream(string fId)
        {
            byte[] pdfBytes = null;
            string query = "SELECT pdf_file FROM pdf_table WHERE id = @id;";
            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", fId);
                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pdfBytes = (byte[])reader["pdf_file"];
                            }
                        }
                    }
                    catch (SqliteException SQLitex)
                    {
                        MessageBox.Show("Error: " + SQLitex.Message);
                    }
                }
            }
            return pdfBytes;
        }

        public bool UpdatePDFInfo(string id, string pdfCategory, string pdfDescription)
        {
            bool success = false;

            string query = @"UPDATE PDF_table SET pdf_category = @pdf_category, pdf_description = @pdf_description where id = @id ";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@pdf_category", pdfCategory);
                    command.Parameters.AddWithValue("@pdf_description", pdfDescription);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        MessageBox.Show("Error: " + SQLitex.Message);
                    }
                }
            }
            return success;
        }


        public bool UpdatePDFCat(string id, string category, string notes)
        {
            bool success = false;

            string query = @"UPDATE PDF_cat SET category = @category, notes = @notes where id = @id ";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@notes", notes);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        MessageBox.Show("Error: " + SQLitex.Message);
                    }
                }
            }
            return success;
        }


        /* 
         
                     command.CommandText = "SELECT " +
                                            "d.id, " +
                                            "d.pdf_name, " +
                                            "d.pdf_category, " +
                                            "IFNULL(e.sub_cat, '') AS subcat, " +
                                            "d.pdf_created, " +
                                            "d.pdf_lastmod, " +
                                            "d.pdf_size, " +
                                            "d.pdf_description " +
                                        "FROM pdf_table d " +
                                        "LEFT JOIN sub_category e ON d.id = e.parent_id;";         
         */



        public DataTable GetAllPDFs()
        {

            DataTable dataTable = new DataTable();
            // Use 'using' statements to ensure connections and commands are properly disposed
            using (var connection = new SqliteConnection(ConnectionString))
            {
                var command = connection.CreateCommand();

                command.CommandText = "select id, pdf_name, pdf_category, pdf_file, pdf_subcat, " +
                                          "pdf_created, pdf_lastmod, pdf_size, pdf_description from pdf_table;";

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    dataTable = new DataTable();
                    dataTable.Load(reader); // Manually load from reader
                                            // Use your dataTable here
                }
            }
            return dataTable;
        }



        public DataTable GetPDFInfo(string fId)
        {
            string query =
                "SELECT * from pdf_table where id = @id;";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                //    using (var command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@id", fId);
                        using (var reader = command.ExecuteReader())
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqliteException SQLitex)
            {
                // Log the exception or handle it appropriately
                MessageBox.Show($"Database Error: {SQLitex.Message}");
                return null;
            }
        }

        // Select * from 
        public DataTable getRecordsCategory(string fCategory)
        {
            string query =
                "SELECT * from pdf_table where pdf_category = @pdf_category;";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                //    using (var command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@pdf_category", fCategory);
                        using (var reader = command.ExecuteReader())
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqliteException SQLitex)
            {
                // Log the exception or handle it appropriately
                MessageBox.Show($"Database Error: {SQLitex.Message}");
                return null;
            }
        }




        //SELECT * from pdf_table where pdf_category = "receipt" AND pdf_subcat = "vehicle"
        public DataTable getRecordsSubCategory(string fCategory, string fSubCategory)
        {
            string query =
                "SELECT * from pdf_table where pdf_category = @pdf_category AND pdf_subcat = @pdf_subcat;";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                //    using (var command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@pdf_category", fCategory);
                        command.Parameters.AddWithValue("@pdf_subcat", fSubCategory);
                        using (var reader = command.ExecuteReader())
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqliteException SQLitex)
            {
                // Log the exception or handle it appropriately
                MessageBox.Show($"Database Error: {SQLitex.Message}");
                return null;
            }
        }



        /*
        If you want, I can also change how the byte[] parameter is added (use DbType = Binary/Blob) to avoid provider issues.
        */

        public bool insertPDF(string fName, byte[] pdfBytes, string fCreated, string fLastmod, string fSize,
                              string fAttributes, string description, string category)
        {
            bool success = false;
            try
            {
                // Using statements ensure that the connection and command are disposed of
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    // Use parameterized queries to prevent SQL injection

                    string insertQuery = "INSERT INTO pdf_table (pdf_name, pdf_file, pdf_description, pdf_category, " +
                        "pdf_created, pdf_size, pdf_lastmod, pdf_attributes) " +
                        "VALUES (@pdf_name, @pdf_file, @pdf_description, @pdf_category, @pdf_created, @pdf_size, @pdf_lastmod, @pdf_attributes);";

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@pdf_name", fName);
                        command.Parameters.AddWithValue("@pdf_file", pdfBytes);
                        command.Parameters.AddWithValue("@pdf_description", description);
                        command.Parameters.AddWithValue("@pdf_category", category);
                        command.Parameters.AddWithValue("@pdf_created", fCreated);
                        command.Parameters.AddWithValue("@pdf_lastmod", fLastmod);
                        command.Parameters.AddWithValue("@pdf_size", fSize);
                        command.Parameters.AddWithValue("@pdf_attributes", fAttributes);

                        command.ExecuteNonQuery();
                    }
                }
                success = true;
            }
            catch (SqliteException SQLitex)
            {
                MessageBox.Show("Error: " + SQLitex.Message);
                success = false;
            }

            return success;

        }
        public bool DeletePDF(string id)
        {
            bool success = false;
            string query = "DELETE FROM pdf_table WHERE id = @id";
            using (var connection = new SqliteConnection(ConnectionString))
            {

                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        // Log the exception or handle it appropriately
                        MessageBox.Show($"Database Error: {SQLitex.Message}");
                        return false;
                    }
                }
            }
        }

        // This method adds a new categorys to the categories table in the SQLite database.
        public bool addCategory(string category, string cat_notes)
        {
            bool success = false;

            string postQuery = "INSERT INTO pdf_cat ( category, notes) VALUES (@category, @notes)";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(postQuery, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@notes", cat_notes);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        MessageBox.Show("Error: " + SQLitex.Message);
                    }
                }
            }
            return success;
        }

        public DataTable getCategoryKeyedList(string tableName, String keyCol, String theId)
        {
            //    var dataSet = new DataSet();
            var dataTable = new DataTable(tableName); // Naming the table helps with data binding

            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText = "select " + keyCol + " AS KeyCol, cast( " + theId
                    + " AS VARCHAR(16)) AS DescrCol from " + tableName + " order by " + keyCol + ";";

                using var reader = command.ExecuteReader();
                dataTable.Load(reader);

                //   dataSet.Tables.Add(dataTable);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
            }


            //  Int32 recCount = genericDs.Tables[0].Rows.Count;
            // MessageBox.Show("Items this dropdown list: " + recCount.ToString());
            return dataTable;
        }

        //   DeleteCategoryById()
        public bool DeleteCategoryById(string id)
        {
            bool success = false;
            string query = "DELETE FROM pdf_cat WHERE id = @id";
            using (var connection = new SqliteConnection(ConnectionString))
            {

                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        // Log the exception or handle it appropriately
                        MessageBox.Show($"Database Error: {SQLitex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool DeleteSubCatById(string id)
        {
            bool success = false;
            string query = "DELETE FROM sub_category WHERE id = @id";
            using (var connection = new SqliteConnection(ConnectionString))
            {

                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqliteException SQLitex)
                    {
                        // Log the exception or handle it appropriately
                        MessageBox.Show($"Database Error: {SQLitex.Message}");
                        return false;
                    }
                }
            }
        }



        #endregion
    }
}

