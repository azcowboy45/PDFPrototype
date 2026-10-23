using System;
using System.Collections.Generic;
using System.Text;

namespace PDFRepo.utils
{
    internal class LogClass
    {
        private string logFilePath;

        public LogClass()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            this.logFilePath = Path.Combine(localAppData, "PDFRepo", "log.txt");
        }
        private void AppendLogLine(string message)
        {
            // 1. Define the line you want to add
            string newLine = message;

            // 2. Set up your path (using AppData\Local like before)
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(localAppData, "PDFRepo", "log.txt");

            try
            {
                // 3. Ensure the folder exists
                string folderPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // 4. Post (append) the text along with a new line break
                File.AppendAllText(filePath, newLine + Environment.NewLine);

              //  MessageBox.Show("Line added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void LogPost(string logEntry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            AppendLogLine($"[{timestamp}] {logEntry}");
        }
    }
}

