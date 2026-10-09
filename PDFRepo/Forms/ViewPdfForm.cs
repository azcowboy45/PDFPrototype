using Microsoft.Data.Sqlite;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDFRepo.DataClasses;


namespace PDFRepo.Forms
{

    public partial class ViewPdfForm : Form
    {
        private byte[] pdfBytes = null;
        private string tempPdfPath = string.Empty;
        public ViewPdfForm(string pdfId)
        {
            //    this.pdfId = pdfId;

            InitializeComponent();
            LoadPDF(pdfId);
            btnLoadPdfFromDb_Click();
        }


        private void LoadPDF(string pdfId)
        {
            DataModel dm = new DataModel();
            this.pdfBytes = dm.GetByteStream(pdfId);
            //     MessageBox.Show("PDF loaded successfully.");

        }

        //********************************  REVFERENCE CODE ****************************************
        private async void btnLoadPdfFromDb_Click()
        {
            try
            {
                // 1. Simulate reading your byte stream from the database
                // (Replace this line with your actual database stream reader logic)

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    MessageBox.Show("No valid PDF data returned from database.", "Error");
                    return;
                }

                // 2. Generate a secure, unique file path in the system Temp folder
                tempPdfPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.pdf");

                // 3. Write the raw bytes out to the temporary file
                File.WriteAllBytes(tempPdfPath, pdfBytes);

                // 4. Ensure WebView2's internal browser environment is ready
                await webView21.EnsureCoreWebView2Async();

                // 5. Instruct WebView2 to target the absolute local file URI
                webView21.CoreWebView2.Navigate(new Uri(tempPdfPath).AbsoluteUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to display PDF: {ex.Message}", "Processing Error");
            }
        }

        // Clean up the temp file from the disk when the form closes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                if (!string.IsNullOrEmpty(tempPdfPath) && File.Exists(tempPdfPath))
                {
                    File.Delete(tempPdfPath);
                }
            }
            catch { /* Ignore cleanup errors if file is locked */ }
        }

        private byte[] GetPdfBytesFromDatabase()
        {
            // Placeholder for your DB retrieval logic: 
            // e.g., using (var stream = reader.GetStream(columnIndex)) { ... }
            return new byte[0];
        }

        private void ViewPdfForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*********************************************************************************************************

    }
}
