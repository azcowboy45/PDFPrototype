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
            takeCommandLable = new Label();
            copyrightLable = new Label();
            userNameLabel = new Label();
            SuspendLayout();
            // 
            // continueButton
            // 
            continueButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            continueButton.BackgroundImageLayout = ImageLayout.None;
            continueButton.Location = new Point(825, 583);
            continueButton.Margin = new Padding(2);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(118, 20);
            continueButton.TabIndex = 0;
            continueButton.Text = "Skip Setup";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // setupButton
            // 
            setupButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            setupButton.Location = new Point(8, 583);
            setupButton.Margin = new Padding(2);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(118, 20);
            setupButton.TabIndex = 1;
            setupButton.Text = "Continue to Setup";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // takeCommandLable
            // 
            takeCommandLable.AutoSize = true;
            takeCommandLable.BackColor = Color.Transparent;
            takeCommandLable.Font = new Font("Vladimir Script", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            takeCommandLable.ForeColor = Color.White;
            takeCommandLable.Location = new Point(55, 160);
            takeCommandLable.Margin = new Padding(2, 0, 2, 0);
            takeCommandLable.Name = "takeCommandLable";
            takeCommandLable.Size = new Size(841, 46);
            takeCommandLable.TabIndex = 2;
            takeCommandLable.Text = "Your PDFRepository, Take Command Of Your PDFs Today!";
            // 
            // copyrightLable
            // 
            copyrightLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            copyrightLable.AutoSize = true;
            copyrightLable.BackColor = Color.Transparent;
            copyrightLable.ForeColor = Color.White;
            copyrightLable.Location = new Point(415, 590);
            copyrightLable.Margin = new Padding(2, 0, 2, 0);
            copyrightLable.Name = "copyrightLable";
            copyrightLable.Size = new Size(161, 15);
            copyrightLable.TabIndex = 3;
            copyrightLable.Text = "@2026 Spring Creek Software";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(304, 85);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(353, 58);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Welcome, New User";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = continueButton;
            ClientSize = new Size(951, 610);
            Controls.Add(userNameLabel);
            Controls.Add(copyrightLable);
            Controls.Add(takeCommandLable);
            Controls.Add(setupButton);
            Controls.Add(continueButton);
            Margin = new Padding(2);
            Name = "SplashScreen";
            Text = "PDFRepo";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button continueButton;
        private Button setupButton;
        private Label takeCommandLable;
        private Label copyrightLable;
        private Label userNameLabel;
    }
}