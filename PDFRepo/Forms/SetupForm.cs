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

namespace PDFRepo.Forms
{
    public partial class SetupForm : Form
    {
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

        private LogClass logger;

        //  C#  forms: How do I represent the path to the users AppData\Local directory
        public SetupForm()
        {
            logger = new LogClass();

            LogPost("Logging from SetupForm ");
            InitializeComponent();

            // Returns: C:\Users\<Username>\AppData\Local
            localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // To combine it with a custom application file or folder safely: We will do settings.json later
            pdfAppPath = Path.Combine(localAppData, "PDFRepo", "settings.json");

            bkupPathTextBox.Text = pdfAppPath;

            LoadSettingsForm();

         //   LogPost("Hello World to the log.");
         //   LogPost("It works!");

        }

        private void LoadSettingsForm()
        {
            // 1. Always verify the file exists first to prevent crashes
            if (!File.Exists( pdfAppPath))
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

                // 4. Send the data back into your specific Form controls
                if (loadedSettings != null)
                {
                    PopulateUiControls(loadedSettings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading configuration: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateUiControls(List<string> settings)
        {
            foreach (var setting in settings)
            {
                var keyValue = setting.Split('=');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0];
                    string value = keyValue[1];
                    switch (key)
                    {
                        case "FirstName":
                            firstNameTextBox.Text = value;
                            break;
                        case "LastName":
                            lastNameTextBox.Text = value;
                            break;
                        case "DBPath":
                            dbPathTextBox.Text = value;
                            break;
                        case "BKUPPath":
                            bkupPathTextBox.Text = value;
                            break;
                        case "EnableLogging":
                            enableLoggingCheckBox.Checked = bool.TryParse(value, out bool enableLogging) && enableLogging;
                            break;
                        case "BypassOnStartup":
                            bypassOnStartupCheckBox.Checked = bool.TryParse(value, out bool bypassOnStartup) && bypassOnStartup;
                            break;
                        default:
                            // Handle unknown keys if necessary
                            break;
                    }
                }
            }
        }





        private List<string> GatherSettings()
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            dbPath = dbPathTextBox.Text;
            bkupPath = bkupPathTextBox.Text;
            enableLogging = enableLoggingCheckBox.Checked.ToString();
            bypassOnStartup = bypassOnStartupCheckBox.Checked.ToString();
            submissionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<string> settings = new List<string>
            {
                $"FirstName={firstName}",
                $"LastName={lastName}",
                $"DBPath={dbPath}",
                $"BKUPPath={bkupPath}",
                $"EnableLogging={enableLogging}",
                $"BypassOnStartup={bypassOnStartup}",
                $"SubmissionDate={submissionDate}"
            };

           // string jsonSettings = JsonSerializer.Serialize(settings);

            return settings;
          //  MessageBox.Show(jsonSettings);
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
                MessageBox.Show("Settings saved successfully!");

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
          //  Gatherettings();
            PostSettings(GatherSettings());
            this.Close();
        }
    }
}
