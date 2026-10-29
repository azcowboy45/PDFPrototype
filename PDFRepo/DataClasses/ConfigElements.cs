using System;
using System.Collections.Generic;
using System.Text;

namespace PDFRepo.DataClasses
{

    public class ConfigElements
    {
        public string firstName { get; set; } = "New User";
        public string lastName { get; set; } = "Unknown";
        public string PdfSearchPath { get; set; } = string.Empty;
        public string dbPath { get; set; } = string.Empty;
        public string bkupPath { get; set; } = string.Empty;
        public string enableLogging { get; set; } = "true";  // Default to true, set to false later if needed
        public string bypassOnStartup { get; set; } = "false";  // Default to false, set to true later if needed via the GUI
        public string showLineNumbers { get; set; } = "false";
        public string submissionDate { get; set; } = string.Empty;

    }
}
