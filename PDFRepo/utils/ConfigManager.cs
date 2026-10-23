
/**
 *  
 * */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace PDFRepo.utils
{

    public class AppConfig
    {
        public string userFirstName { get; set; } = "Bud";
        public string userLastname { get; set; } = "Alexander";
        public string password { get; set; } = "xyzzy";
        public string userID { get; set; } = "Guest";
        public string databaseLocation { get; set; } = "Guest";
        public string backupDirectory { get; set; } = "";
        public string backUpFrequency { get; set; } = "";

    }

    public class ConfigManager
    {

        public static void SaveConfiguration(AppConfig config)
        {
            // 1. Get the AppData Roaming folder path
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // 2. Combine paths to create your unique application directory
            string companyName = "SpringCreekSoftware";
            string projectName = "PDFRepo";
            string folderPath = Path.Combine(appDataPath, companyName, projectName);

            // 3. Ensure the folder exists on Windows 11
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // 4. Combine folder path with the config file name
            string filePath = Path.Combine(folderPath, "config.json");

            // 5. Serialize the object to a formatted JSON string
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(config, options);

            // 6. Write the text file out safely 
            File.WriteAllText(filePath, jsonString);
        }

        public static AppConfig LoadConfiguration()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filePath = Path.Combine(appDataPath, "SpringCreekSoftware", "PDFRepo", "config.json");

            // Return defaults if the file hasn't been created yet
            if (!File.Exists(filePath))
            {
                return new AppConfig();
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<AppConfig>(jsonString) ?? new AppConfig();
        }

        public static void UpdateConfiguration(string propertyName, string newValue)
        {
            AppConfig config = LoadConfiguration();
            // Use reflection to set the property dynamically
            var property = typeof(AppConfig).GetProperty(propertyName);
            if (property != null && property.CanWrite)
            {
                property.SetValue(config, newValue);
                SaveConfiguration(config);
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' does not exist or is not writable.");
            }
        }

        public static string GetConfigurationValue(string propertyName)
        {
            AppConfig config = LoadConfiguration();
            var property = typeof(AppConfig).GetProperty(propertyName);
            if (property != null && property.CanRead)
            {
                return property.GetValue(config)?.ToString() ?? string.Empty;
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' does not exist or is not readable.");
            }
        }

    }
}
