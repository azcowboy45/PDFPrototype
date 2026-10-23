
using System;
// using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using PDFRepo.DataClasses;




namespace PDFRepo
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public bool bypassOnStartup { get; set; } = true;
        public string backupPath { get; set; } = string.Empty;
        public string configPath { get; set; } = string.Empty;



        [STAThread]
        static void Main()
        {
            Program myProgram = new Program();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PDF_list(myProgram));
        }
    }
}