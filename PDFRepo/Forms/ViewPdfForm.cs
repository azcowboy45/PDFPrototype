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
            InitializeComponent();
            LoadPDF(pdfId);
            btnLoadPdfFromDb_Click();
            AddToolTips();

            this.Load += WebViewForm_Load;
        }

        private void AddToolTips()
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(exitButton, "Click to exit the form.");
        }



        /// <summary>
        /// Runs when the form loads. This ensures the designer control is fully drawn 
        /// and ready to initialize its underlying Chromium browser engine.
        /// </summary>
        private async void WebViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Accessing the designer control ('webView21' or 'webView' depending on your designer name)
                // Swap 'webView21' below if the designer named it with a number.
                await webView21.EnsureCoreWebView2Async(null);

                // Attach the rendering safety-net event for landscape/odd dimensions
                webView21.NavigationCompleted += WebView_NavigationCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize browser engine: {ex.Message}", "Viewer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //********************************  REFERENCE CODE ****************************************
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


        private void LoadPDF(string pdfId)
        {
            DataModel dm = new DataModel();
            this.pdfBytes = dm.GetByteStream(pdfId);
            //     MessageBox.Show("PDF loaded successfully.");
            pdfIdTextBox.Text = pdfId;

        }

        /// <summary>
        /// Executes immediately after the PDF engine parses the document structure.
        /// Explicitly overrides shadow DOM rules to smooth out any mixed page dimensions.
        /// </summary>
        private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess) return;

            string script = @"
                const viewer = document.querySelector('pdf-viewer') || document.querySelector('embed');
                if (viewer && viewer.viewport) {
                    viewer.viewport.fitToWidth(); 
                }
            ";

            await webView21.ExecuteScriptAsync(script);
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

        /*
        private byte[] GetPdfBytesFromDatabase()
        {
            // Placeholder for your DB retrieval logic: 
            // e.g., using (var stream = reader.GetStream(columnIndex)) { ... }
            return new byte[0];
        }
*/

        private void ViewPdfForm_Load(object sender, EventArgs e)
        {
            return;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //*********************************************************************************************************

    }
}
