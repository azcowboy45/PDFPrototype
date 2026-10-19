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
            continueButton.FlatAppearance.BorderSize = 2;
            continueButton.FlatStyle = FlatStyle.Popup;
            continueButton.Location = new Point(1174, 952);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(169, 47);
            continueButton.TabIndex = 0;
            continueButton.Text = "Contine to App";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // setupButton
            // 
            setupButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            setupButton.FlatAppearance.BorderSize = 2;
            setupButton.FlatStyle = FlatStyle.Popup;
            setupButton.Location = new Point(16, 952);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(169, 47);
            setupButton.TabIndex = 1;
            setupButton.Text = "Setup";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // takeCommandLable
            // 
            takeCommandLable.AutoSize = true;
            takeCommandLable.BackColor = Color.Transparent;
            takeCommandLable.Font = new Font("Vladimir Script", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            takeCommandLable.ForeColor = Color.White;
            takeCommandLable.Location = new Point(79, 267);
            takeCommandLable.Name = "takeCommandLable";
            takeCommandLable.Size = new Size(1237, 67);
            takeCommandLable.TabIndex = 2;
            takeCommandLable.Text = "With PDFRepo, You Take Command Of Your PDFs Today!";
            // 
            // copyrightLable
            // 
            copyrightLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            copyrightLable.AutoSize = true;
            copyrightLable.BackColor = Color.Transparent;
            copyrightLable.ForeColor = Color.White;
            copyrightLable.Location = new Point(593, 983);
            copyrightLable.Name = "copyrightLable";
            copyrightLable.Size = new Size(250, 25);
            copyrightLable.TabIndex = 3;
            copyrightLable.Text = "@2026 Spring Creek Software";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(434, 142);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(525, 87);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Welcome, New User";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = continueButton;
            ClientSize = new Size(1359, 1017);
            Controls.Add(userNameLabel);
            Controls.Add(copyrightLable);
            Controls.Add(takeCommandLable);
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
        private Label takeCommandLable;
        private Label copyrightLable;
        private Label userNameLabel;
    }
}