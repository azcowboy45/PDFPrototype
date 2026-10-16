namespace PDFRepo.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            continueButton = new Button();
            setupButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // continueButton
            // 
            continueButton.BackgroundImageLayout = ImageLayout.None;
            continueButton.Location = new Point(1207, 971);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(140, 34);
            continueButton.TabIndex = 0;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // setupButton
            // 
            setupButton.Location = new Point(12, 971);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(140, 34);
            setupButton.TabIndex = 1;
            setupButton.Text = "Skip Setup";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 187);
            label1.Name = "label1";
            label1.Size = new Size(1091, 87);
            label1.TabIndex = 2;
            label1.Text = "PDFRepository: Utilize your PDF Files!";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = continueButton;
            ClientSize = new Size(1359, 1017);
            Controls.Add(label1);
            Controls.Add(setupButton);
            Controls.Add(continueButton);
            Name = "SplashScreen";
            Text = "PDFRepo";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button continueButton;
        private Button setupButton;
        private Label label1;
    }
}