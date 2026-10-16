using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace PDFRepo.DataClasses
{
    internal class ManageConfigClass
    {
        public ConfigElements ce;
        private string pdfAppPath = String.Empty;
        private string localAppData = String.Empty;
        private string logEntry = String.Empty;

        /*
          private string pdfAppPath = String.Empty;
          private string localAppData = String.Empty;
          private string logEntry = String.Empty;
          string firstName = string.Empty;
          string lastName = string.Empty;
          string dbPath = string.Empty;
          string bkupPath = string.Empty;
          string enableLogging = string.Empty;
          string bypassOnStartup = string.Empty;
          string submissionDate = string.Empty;
          */
        private LogClass logger;

        public ManageConfigClass()
        {   
            logger = new LogClass();
           // LoadConfig()
            localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            pdfAppPath = Path.Combine(localAppData, "PDFRepo", "settings.json");

        }
        private void Loadconfig()
        {
            // 1. Always verify the file exists first to prevent crashes
            if (!File.Exists(pdfAppPath))
            {
                MessageBox.Show("No configuration file found. Using defaults.");
                return;
            }

            try
            {
                // 2. Read the raw JSON string out of the file
                string jsonString = File.ReadAllText(pdfAppPath);

                // 3. Convert JSON back into a C# List<string>
                List<string> loadedSettings = JsonSerializer.Deserialize<List<string>>(jsonString);

                
                if (loadedSettings != null)
                {
                  //  PopulateConfigElements();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading configuration: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostSettings(List<string> settings)
        {
            try
            {
                // Ensure the directory exists
                string directoryPath = Path.GetDirectoryName(pdfAppPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                string jsonSettings = JsonSerializer.Serialize(settings);
                // Write the settings to the file
                File.WriteAllText(pdfAppPath, jsonSettings);
                MessageBox.Show("Settings updated.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving settings: {ex.Message}");
            }
        }



        private void LogPost(string logEntry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            logger.AppendLogLine($"[{timestamp}] {logEntry}");
        }


    }
}