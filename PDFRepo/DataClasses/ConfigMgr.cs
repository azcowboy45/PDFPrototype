using PDFRepo.DataClasses;
using PDFRepo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PDFRepo.DataClasses
{
    public class ConfigMgr
    {
        private string PdfSearchPath = string.Empty;
        private string localAppData = string.Empty;
        private string logEntry = string.Empty;
        private LogClass logger;
        public ConfigElements config;

        private Program program;

        private string dbPath = string.Empty;
        /// <summary>
        /// 
        /// Initializes a new instance of the ConfigMgr class.
        /// </summary>
        /// <remarks>Initializes configuration and logging components, sets the settings 
        ///         path, and loads configuration
        ///         data during construction.
        ///         </remarks>
        /// 
        /// <param name="program">Program instance that provides application paths 
        /// and receives the resolved settings path.</param>
        ///
        public ConfigMgr(Program program)
        {
            this.program = program;
            this.dbPath = this.program.dbPath;
            this.PdfSearchPath = this.program.PdfSearchPath;

            config = new ConfigElements();
            logger = new LogClass();
            program.settingsPath = DefineSettingsPath();
            Loadconfig();
        }


        #region output
        public ConfigElements GetCfg()
        {
            return this.config;
        }
       private string DefineSettingsPath()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(localAppData, "PDFRepo", "settings.json");
        }
        private void Loadconfig()
        {
            // 1. Always verify the file exists first to prevent crashes
            if (!File.Exists(program.settingsPath))
            {
                LoadDefaults();
                return;
            }

            try
            {
                // 2. Read the raw JSON string out of the file
                string jsonString = File.ReadAllText(program.settingsPath);

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
                            config.lastName = value;
                            break;
                        case "PdfSearchPath":
                            config.PdfSearchPath = value;
                            break;

                        case "DbPath":
                            config.dbPath = this.dbPath;  // Always use the correct path for database (dbPath)
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
                        case "ShowLineNumbers":
                            config.showLineNumbers = value;
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

        #region postSettings

        public void SaveOneJsonParm(string parm)
        {
            GetDirectoryPath();

            try
            {
                // backup
                File.Copy(program.settingsPath, program.settingsPath + ".bak", true);

                string jsonString = File.ReadAllText(program.settingsPath);
                JsonNode configNode = JsonNode.Parse(jsonString);

                var options = new JsonSerializerOptions { WriteIndented = true };
                if (configNode is JsonObject obj)
                {
                    obj["BkupPath"] = parm;
                    File.WriteAllText(program.settingsPath , obj.ToJsonString(options));
                }
                else if (configNode is JsonArray arr)
                {
                    bool found = false;
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] is JsonValue val)
                        {
                            string s = val.GetValue<string>();
                            if (s.StartsWith("BkupPath=", StringComparison.OrdinalIgnoreCase))
                            {
                                arr[i] = $"BkupPath={parm}";
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        arr.Add($"BkupPath={parm}");
                    }

                    File.WriteAllText(program.settingsPath, arr.ToJsonString(options));
                }
                else
                {
                    throw new InvalidOperationException("Unsupported JSON root type.");
                }

                MessageBox.Show("Configuration element updated successfully!");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        } 
        public void UpdateJsonConfig(
            string firstName,
                                 string lastName,
                                 string pdfSearchPath,
                                 string dbPath,
                                 string bkupPath,
                                 string enableLogging,
                                 string bypassOnStartup,
                                 string showLineNumbers,
                                 string backupPath
                                 )
        {
            string submissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<string> settings = new List<string>
            {
                $"FirstName={firstName}",
                $"LastName={lastName}",
                $"PdfSearchPath={pdfSearchPath}",
                $"DbPath={dbPath}",
                $"BkupPath={bkupPath}",
                $"EnableLogging={enableLogging}",
                $"BypassOnStartup={bypassOnStartup}",
                $"ShowLineNumbers={showLineNumbers}",
                $"BackupPath={backupPath}",
                $"SubmissionDate={submissionDate}"
            };

            PostSettings(settings);
            logger.LogPost("Configuration updated.");
        }



        private void PostSettings(List<string> settings)
        {
            try
            {
                // Ensure the directory exists
                GetDirectoryPath();
                string jsonSettings = JsonSerializer.Serialize(settings);
                // Make sure we have a fresh file
                // File.Delete(pdfAppPath);
                // Write the settings to the file
                File.WriteAllText(program.settingsPath, jsonSettings);
                MessageBox.Show("Settings updated.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving settings: {ex.Message}");
            }
        }

        #endregion

        #region helpers

        private void GetDirectoryPath()
        {
            string directoryPath = Path.GetDirectoryName(program.settingsPath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        private string BuildDefaultBackupPath()
        {
            // 1. Get the base Documents folder path
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // 2. Safely attach your subfolder name
            string completePath = Path.Combine(documentsPath, "PDFRepoBackups");

            return completePath;
        }
        private void LoadDefaults()
        {
            config.firstName = "Your first name";
            config.lastName = "Your Last name";
            config.dbPath = this.dbPath;
            config.bkupPath = BuildDefaultBackupPath(); //suggested default backup path
            config.enableLogging = "true";  // We may want to set this to false later if needed
            config.bypassOnStartup = "false";
            config.showLineNumbers = "false";
            config.submissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        #endregion

    }
}