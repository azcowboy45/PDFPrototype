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
    internal class ManageConfigClass
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
         *  We will use this in the constructor to set the pdfAppPath variable
         *  and then use it in LoadConfig() and PostSettings() methods.
         *  
         *  Then if the settings.json file does not exist, we can create it with default values.
         *  Else, we read it and deserialize it into the ConfigElements class
         *  
         *  Access methods:
         *  
         *      x1. We will have a method to get the current settings (GetConfig) and a method to 
         *        update the settings (UpdateConfig).
         *  
         *      x2. We can also have a method to reset the settings to default values (ResetConfig). 
         *        (maybe not needed)
         *  
         *      3, We can receive a list for serialization and deserialization, or we can use the 
         *        ConfigElements class directly.
         *  
         *      4, This list can then be converted to json to then and posted to settings.json file.
         *  
         */



        /**
         *  Constructor: Initialize the config and logger, set the pdfAppPath, and load the configuration.
         */

        public ManageConfigClass()
        { 
            config = new ConfigElements(); ;
            logger = new LogClass();
           // LoadConfig()
            localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pdfAppPath = Path.Combine(localAppData, "PDFRepo", "settings.json");
            Loadconfig();
        }

        public ConfigElements GetCfg()
        {
            return config;
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
                        case "DBPath":
                            config.dbPath = value;
                            break;
                        case "BKUPPath":
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
        
        #region postSettingsAndLoggs
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