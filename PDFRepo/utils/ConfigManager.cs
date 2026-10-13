
/**
 * 
 * This is a prototype for a configuration manager that saves and loads application settings to a JSON file in the user's AppData folder.
 * To start, we will want to do just a text file, but we will want to eventually encrypt the file and store it in a secure location.    
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
    }
}
