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
            label2 = new Label();
            userNameLabel = new Label();
            SuspendLayout();
            // 
            // continueButton
            // 
            continueButton.BackgroundImageLayout = ImageLayout.None;
            continueButton.Location = new Point(1178, 971);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(169, 34);
            continueButton.TabIndex = 0;
            continueButton.Text = "Skip Setup";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // setupButton
            // 
            setupButton.Location = new Point(12, 971);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(169, 34);
            setupButton.TabIndex = 1;
            setupButton.Text = "Continue to Setup";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // takeCommandLable
            // 
            takeCommandLable.AutoSize = true;
            takeCommandLable.BackColor = Color.Transparent;
            takeCommandLable.Font = new Font("Vladimir Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeCommandLable.ForeColor = Color.White;
            takeCommandLable.Location = new Point(135, 292);
            takeCommandLable.Name = "takeCommandLable";
            takeCommandLable.Size = new Size(1114, 58);
            takeCommandLable.TabIndex = 2;
            takeCommandLable.Text = "Your PDFRepository, Take Command Of Your PDFs Today!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(593, 983);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 3;
            label2.Text = "@2026 Spring Creek Software";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(435, 142);
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
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = continueButton;
            ClientSize = new Size(1359, 1017);
            Controls.Add(userNameLabel);
            Controls.Add(label2);
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
        private Label label2;
        private Label userNameLabel;
    }
}