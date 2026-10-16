using System;
using System.Collections.Generic;
using System.Text;

namespace PDFRepo.DataClasses
{

    public class ConfigElements
    {
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string dbPath { get; set; } = string.Empty;
        public string bkupPath { get; set; } = string.Empty;
        public string enableLogging { get; set; } = string.Empty;
        public string bypassOnStartup { get; set; } = string.Empty;
        public string submissionDate { get; set; } = string.Empty;

    }
}
