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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


#endregion
namespace PDFRepo.DataClasses
{
    class DataModel
    {
        /**
         * Placeholder comment.
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

        public DataTable GetAllPDFs()
        {

            DataTable dataTable = new DataTable();
            // Use 'using' statements to ensure connections and commands are properly disposed
            using (var connection = new SqliteConnection(ConnectionString))
            {
                var command = connection.CreateCommand();
                
                command.CommandText = "select id, pdf_name, pdf_file, pdf_created, " +
                    "pdf_lastmod, pdf_size, pdf_category, pdf_description from pdf_table;";

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

        public bool InsertPDF(string PDFName, string PDFData, string PDFDescription, string PDFCategory, string PDFCreated, string PDFSize)
        {
            bool success = false;
            try
            {
                // Using statements ensure that the connection and command are disposed of
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    // Use parameterized queries to prevent SQL injection

                    string insertQuery = "INSERT INTO pdf_table ( pdf_name, pdf_file, pdf_description, pdf_category, " +
                        "pdf_created, pdf_size ) " +
                        "VALUES (@pdf_name, @pdf_file, @pdf_description, @pdf_category, @pdf_created, @pdf_size)";

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@pdf_name", PDFName);
                        command.Parameters.AddWithValue("@pdf_file", PDFData);
                        command.Parameters.AddWithValue("@pdf_description", PDFDescription);
                        command.Parameters.AddWithValue("@pdf_category", PDFCategory);
                        command.Parameters.AddWithValue("@pdf_created", PDFCreated);
                        command.Parameters.AddWithValue("@pdf_size", PDFSize);
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
        public bool UpdateUnitofMeasure(string id, string measure)
        {
            bool success = false;

            string postQuery = "UPDATE unit_of_measure SET measure = @imeasure where id = @id ";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(postQuery, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@measure", measure);
                    command.Parameters.AddWithValue("@id", id);
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





        public int GetIngredientIdByName(string ingredientStr)
        {
            int ingredientId = -1;
            string query = "SELECT ID FROM selectable_ingredients WHERE ingredients = @ingredientName";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ingredientName", ingredientStr);
                    try
                    {
                        connection.Open();
                        object value = command.ExecuteScalar();
                        if (value != null && value != DBNull.Value)
                        {
                            ingredientId = Convert.ToInt32(value);

                        }
                    }
                    catch (SqliteException SQLitex)
                    {
                        // Log the exception or handle it appropriately
                        MessageBox.Show($"Database Error: {SQLitex.Message}");
                        return -1;
                    }
                }
            }
            return ingredientId;
        }

        public String GetCategoryById(string ingredientKey)
        {
            string result = null;
            string query = "SELECT category FROM selectable_ingredients WHERE ID = " + ingredientKey;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object value = command.ExecuteScalar();

                        if (value != null && value != DBNull.Value)
                        {
                            result = Convert.ToString(value);
                        }
                    }
                    catch (SqliteException SQLitex)
                    {
                        // Log the exception or handle it appropriately
                        MessageBox.Show($"Database Error: {SQLitex.Message}");
                        return null;
                    }
                }
            }
            return result;
        }

        // dataModel.DeleteSelectedMeasurementById(id)
        // Deletes a measuremfent type by its ID.
        // 
        public bool DeleteSelectedIngredientById(string id)
        {
            bool success = false;
            string query = "DELETE FROM selectable_ingredients WHERE id = @id";
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



        // Deletes a direction record by its ID. Also deletes any orphaned ingredients associated with the direction.
        public bool DeleteSelectedMeasurementById(string id)
        {
            bool success = false;
            string query = "DELETE FROM unit_of_measure WHERE id = @id";
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


        public bool UpdateSelectableIngredients(string id, string ingredients, string category, string additionalInfo)
        {
            bool success = false;

            string postQuery = "UPDATE selectable_ingredients SET ingredients = @ingredients, category = @category, additionalInfo = @additionalInfo where id = @id ";

            using (var connection = new SqliteConnection(ConnectionString))
            {
                using (var command = new SqliteCommand(postQuery, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@ingredients", ingredients);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@additionalInfo", additionalInfo);
                    command.Parameters.AddWithValue("@id", id);
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

        #endregion
    }
}

/*



         * Configuration : only select all and update is required. 
         *  New records are never added.
         * UpdateConfig(yourNameTextBox.Text,
                                           userIdTextBox.Text,
                                           pwTextBox.Text,
                                           imageDirTextBox.Text,
                                           emailTextBox.Text,
                                           backupDirTextBox.Text,
                                           pwTextBox.Text
                                           );


        public bool UpdateConfig(string[] parameterList)
        {
            bool success = false;
            int id = 0;
            foreach (string parameter in parameterList)
            {
                if (DoUpdate(id.ToString(), parameter))
                {
                    id++;
                    success = true;
                }
                else
                {
                    success = false;
                    break;
                }
            }
            return success;
        }


        public bool DoUpdate(string id, string parameter)
        {

            string query = "UPDATE config SET parameters = @parameter WHERE id= @id;";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@parameter", parameter);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        return true; // Return true if update was successful
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show($"Error updating configuration parameter: {ex.Message}");
                return false;
            }
        }

        public DataTable GetConfigRecords()
        {
            string query =
                "SELECT * from config;";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                using (var command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
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

        public bool SetSkipParameter(bool skip)
        {
            bool success = false;
            string skipStatus = "0";
            if (skip)
            {
                skipStatus = "1";
            }
            string query = "UPDATE config SET parameters = @skipStatus WHERE selector = 'no_login';";
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@skipStatus", skipStatus);
                        int rowsAffected = command.ExecuteNonQuery();
                        success = true; // Return true if update was successful
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show($"Error updating skip parameter: {ex.Message}");
                success = false;
            }

            return success;

        }


 * 
 * */

