using PDFRepo.DataClasses;
using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PDFRepo.DataClasses
{
    public class Configuration
    {
        /*  Strings that were used in SetupForm.cs but are not needed here, 
        *  as we will use the ConfigElements class instead
         string firstName = string.Empty;
         string lastName = string.Empty;
         string dbPath = string.Empty;
         string bkupPath = string.Empty;
         string enableLogging = string.Empty;
         string bypassOnStartup = string.Empty;
         string submissionDate = string.Empty;
         */


        private string pdfAppPath = string.Empty;
        private string localAppData = string.Empty;
        private string logEntry = string.Empty;
        private LogClass logger;
        public ConfigElements config;
        /**
         *  Constructor: Initialize the config and logger, set the pdfAppPath, and load the configuration.
         */

        public Configuration()
        { 
            config = new ConfigElements(); ;
            logger = new LogClass();;
            this.pdfAppPath = SetLocalAppDataPath();
            Loadconfig();
        }
        public ConfigElements GetCfg()
        {
            return config;
        }
        private string SetLocalAppDataPath()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(localAppData, "PDFRepo", "settings.json");
        }

        #region loadAndParseSettingsFile
        private void Loadconfig()
        {
            // 1. Always verify the file exists first to prevent crashes
            if (!File.Exists(pdfAppPath))
            {
                LoadDefaults();
                return;
            }

            try
            {
                // 2. Read the raw JSON string out of the file
                string jsonString = File.ReadAllText(pdfAppPath);

                // 3. Convert JSON back into a C# List<string>
                List<string> settingsList = JsonSerializer.Deserialize<List<string>>(jsonString);

                PopulateConfigElements(settingsList);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading configuration: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateConfigElements(List<string> settingsList)
        {
            // Address elements by their position index
            foreach (var setting in settingsList)
            {
                var keyValue = setting.Split('=');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0];
                    string value = keyValue[1];
                    switch (key)
                    {
                        case "FirstName":
                            config.firstName = value;
                            break;
                        case "LastName":
                            config.lastName  = value;
                            break;
                        case "DbPath":
                            config.dbPath = this.pdfAppPath;  // Always use the correct path for DbPath
                            break;
                        case "BkupPath":
                            config.bkupPath = value;
                            break;
                        case "EnableLogging":
                            config.enableLogging = value;
                            break;
                        case "BypassOnStartup":
                            config.bypassOnStartup = value;
                            break;
                        case "SubmissionDate":
                            config.submissionDate = value;
                            break;
                        default:
                            // Handle unknown keys if necessary
                            break;
                    }
                }
            }
        }
        #endregion
        
        #region postSettingsAndLog

        public void UpdateJsonConfig(string firstName, 
                                 string lastName, 
                                 string dbPath, 
                                 string bkupPath, 
                                 string enableLogging, 
                                 string bypassOnStartup)
        {
            string submissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<string> settings = new List<string>
            {
                $"FirstName={firstName}",
                $"LastName={lastName}",
                $"DbPath={dbPath}",
                $"BkupPath={bkupPath}",
                $"EnableLogging={enableLogging}",
                $"BypassOnStartup={bypassOnStartup}",
                $"SubmissionDate={submissionDate}"
            };

            PostSettings(settings);
            LogPost("Configuration updated.");
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
                // Make sure we have a fresh file
                // File.Delete(pdfAppPath);
                // Write the settings to the file
                File.WriteAllText(pdfAppPath, jsonSettings);
                MessageBox.Show("Settings updated.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving settings: {ex.Message}");
            }
        }

        #endregion

        #region helpers
        private void LoadDefaults()
        {
            config.firstName = string.Empty;
            config.lastName = string.Empty;
            config.dbPath = string.Empty;
            config.bkupPath = string.Empty;
            config.enableLogging = string.Empty;
            config.bypassOnStartup = string.Empty;
            config.submissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void LogPost(string logEntry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            logger.AppendLogLine($"[{timestamp}] {logEntry}");
        }
        #endregion


    }
}