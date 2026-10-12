namespace PDFRepo.Forms
{
    partial class ViewPdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdfIdTextBox = new TextBox();
            label1 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // pdfIdTextBox
            // 
            pdfIdTextBox.Enabled = false;
            pdfIdTextBox.Location = new Point(554, 1206);
            pdfIdTextBox.Name = "pdfIdTextBox";
            pdfIdTextBox.ReadOnly = true;
            pdfIdTextBox.Size = new Size(98, 31);
            pdfIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 1209);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "PDFRepo ID:";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-2, -2);
            webView21.Name = "webView21";
            webView21.Size = new Size(1145, 1175);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1020, 1204);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ViewPdfForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 1250);
            Controls.Add(exitButton);
            Controls.Add(webView21);
            Controls.Add(label1);
            Controls.Add(pdfIdTextBox);
            Name = "ViewPdfForm";
            Text = "View PDF";
            Load += ViewPdfForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox pdfIdTextBox;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button exitButton;
    }
}