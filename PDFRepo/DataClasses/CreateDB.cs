using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data;

namespace PDFRepo.DataClasses
{
    public class CreateDB

    {
        private string ConnectionString;
        private string localAppData = String.Empty;

        public CreateDB()
        {
            // Use Path.Combine to ensure the path is constructed correctly across different operating systems
            localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // To combine it with a custom application file or folder safely: We will do settings.json later
            string dbPath = Path.Combine(localAppData, "PDFRepo", "PDFRepo.db");

            ConnectionString = $"Data Source={dbPath};";
        }
        public void CreateDatabase()
        {

            InitializeDatabase();

        }

        private void InitializeDatabase()
        {
            try
            {                 // Ensure the directory exists
                string directoryPath = Path.Combine(localAppData, "PDFRepo");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                // Create the database and tables
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    // This call automatically creates the 'PDFRepo.db' file if it doesn't exist
                    connection.Open();

                    // Build your schema programmatically
                    string createTablesSql = @"
                                        PRAGMA foreign_keys = off;
                                        

                                        -- Table: pdf_cat
                                        CREATE TABLE IF NOT EXISTS pdf_cat (
                                            id       INTEGER,
                                            category TEXT    UNIQUE,
                                            notes    TEXT,
                                            PRIMARY KEY (
                                                id AUTOINCREMENT
                                            )
                                        );


                                        -- Table: PDF_table
                                        CREATE TABLE IF NOT EXISTS PDF_table (
                                            id              INTEGER,
                                            pdf_name        TEXT    NOT NULL,
                                            pdf_category    TEXT,
                                            pdf_subcat      TEXT,
                                            pdf_created     TEXT,
                                            pdf_size        TEXT,
                                            pdf_attributes  TEXT,
                                            pdf_lastmod     TEXT,
                                            pdf_file        BLOB    NOT NULL,
                                            pdf_description TEXT,
                                            PRIMARY KEY (
                                                id AUTOINCREMENT
                                            )
                                        );


                                        -- Table: sub_category
                                        CREATE TABLE IF NOT EXISTS sub_category (
                                            id        INTEGER PRIMARY KEY AUTOINCREMENT,
                                            sub_cat   TEXT,
                                            notes     TEXT,
                                            parent_id INTEGER,
                                            FOREIGN KEY (
                                                parent_id
                                            )
                                            REFERENCES pdf_table (id) ON DELETE CASCADE
                                        );

                                        PRAGMA foreign_keys = on;";

                    using (var command = new SqliteCommand(createTablesSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error initializing database: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


