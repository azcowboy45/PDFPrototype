using System;
using System.Collections.Generic;
using System.Text;

namespace PDFRepo.DataClasses
{
    internal class ConfigElements
    {
        public string pdfAppPath { get; set; }
        public string localAppData { get; set; }
        public string logEntry { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dbPath { get; set; }
        public string bkupPath { get; set; }
        public string enableLogging { get; set; }
        public string bypassOnStartup { get; set; }
        public string submissionDate { get; set; }

    }
}
