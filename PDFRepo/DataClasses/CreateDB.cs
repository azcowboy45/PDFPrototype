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
        private string dbPath = String.Empty;

        public CreateDB(Program programReference)
        {
            // Use Path.Combine to ensure the path is constructed correctly across different operating systems
            this.localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // To combine it with a custom application file or folder safely: We will do settings.json later
            this.dbPath = Path.Combine(localAppData, "PDFRepo", "PDFRepo.db");

            ConnectionString = $"Data Source={this.dbPath};";

            programReference.dbPath = this.dbPath; // Assuming _program is a static reference to your main program class
        }
        public string CreateDatabase()
        {

            if (InitializeDatabase())
            {
                AddSampleCategories();
            }
            else
            {
                MessageBox.Show("Database creation failed.");
            }
            return this.dbPath;

        }

        private bool InitializeDatabase()
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
                    string createTablesSql = @"BEGIN TRANSACTION;
                        CREATE TABLE IF NOT EXISTS ""PDF_table"" (
	                        ""id""	INTEGER,
	                        ""pdf_name""	TEXT NOT NULL,
	                        ""pdf_category""	TEXT,
	                        ""pdf_subcat""	TEXT,
	                        ""pdf_created""	TEXT,
	                        ""pdf_size""	TEXT,
	                        ""pdf_attributes""	TEXT,
	                        ""pdf_lastmod""	TEXT,
	                        ""pdf_file""	blob NOT NULL,
	                        ""pdf_description""	TEXT,
	                        PRIMARY KEY(""id"" AUTOINCREMENT)
                        );
                        CREATE TABLE IF NOT EXISTS ""pdf_cat"" (
	                        ""id""	INTEGER,
	                        ""category""	TEXT UNIQUE,
	                        ""notes""	TEXT,
	                        PRIMARY KEY(""id"" AUTOINCREMENT)
                        );
                        CREATE TABLE IF NOT EXISTS ""sub_category"" (
	                        ""id""	INTEGER,
	                        ""sub_cat""	TEXT UNIQUE,
	                        ""notes""	TEXT,
	                        ""parent_id""	INTEGER,
	                        PRIMARY KEY(""id"" AUTOINCREMENT)
                        );
                        COMMIT;";

                    using (var command = new SqliteCommand(createTablesSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error initializing database: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AddSampleCategories()
        {
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    // Check if the pdf_cat table is empty
                    string checkSql = "SELECT COUNT(*) FROM pdf_cat";
                    using (var checkCommand = new SqliteCommand(checkSql, connection))
                    {
                        long count = (long)checkCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            // Insert sample categories
                            string insertSql = @"
                                INSERT INTO pdf_cat (category, notes) VALUES ('HowTo', 'Any ""How To"" documents');
                                INSERT INTO pdf_cat (category, notes) VALUES ('manuals', 'Pdfs documents about equipment or software.');
                                INSERT INTO pdf_cat (category, notes) VALUES ('recipe', 'Pdfs documents about equipment or software.');
                                INSERT INTO pdf_cat (category, notes) VALUES ('receipt', 'Documents from busines showing payment.');
                            
                                INSERT INTO sub_category(sub_cat, notes) VALUES('software', 'Software manuals or other related documents');
                                INSERT INTO sub_category(sub_cat, notes) VALUES('vehicle', 'Any documents related to vehicles');
                                INSERT INTO sub_category(sub_cat, notes) VALUES('anytime', 'Subcategory oriented to recipies.');
                                INSERT INTO sub_category(sub_cat, notes) VALUES('U.S.', 'Forms and letters form the US Government'); ";



                            using (var insertCommand = new SqliteCommand(insertSql, connection))
                            {
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error adding sample categories: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


