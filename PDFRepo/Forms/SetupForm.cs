using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDFRepo.utils;

namespace PDFRepo.Forms
{
    public partial class SetupForm : Form
    {
        private string pdfAppPath = String.Empty;
        private string localAppData= String.Empty;
        private string logEntry = String.Empty;
    //    string timestamp = String.Empty;
        private LogClass logger;

        //  C#  forms: How do I represent the path to the users AppData\Local directory
        public SetupForm()
        {
            logger = new LogClass();

            LogPost("Logging from SetupForm ");
            InitializeComponent();
            //    pdfAppPath = "C:\\Users\\bud\\AppData\\Local\\PDFRepo\\config";


            // Returns: C:\Users\<Username>\AppData\Local
            localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // To combine it with a custom application file or folder safely: We will do settings.json later
            pdfAppPath = Path.Combine(localAppData, "PDFRepo", "pdfrepo.cfg");

            configPathTextBox.Text = pdfAppPath;

            LogPost("Hello World to the log.");
            LogPost("It works!");

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
    }
}
