namespace PDFRepo.Forms
{
    partial class BackupForm
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
            label2 = new Label();
            bkupPathTextBox = new TextBox();
            backupNowButton = new Button();
            exitButton = new Button();
            restoreButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 6;
            label2.Text = "Backup Path:";
            // 
            // bkupPathTextBox
            // 
            bkupPathTextBox.Location = new Point(130, 106);
            bkupPathTextBox.Name = "bkupPathTextBox";
            bkupPathTextBox.Size = new Size(842, 31);
            bkupPathTextBox.TabIndex = 7;
            // 
            // backupNowButton
            // 
            backupNowButton.Location = new Point(11, 12);
            backupNowButton.Name = "backupNowButton";
            backupNowButton.Size = new Size(171, 33);
            backupNowButton.TabIndex = 10;
            backupNowButton.Text = "Backup";
            backupNowButton.UseVisualStyleBackColor = true;
            backupNowButton.Click += backupNowButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(801, 198);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(171, 33);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restoreButton
            // 
            restoreButton.Location = new Point(801, 12);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(171, 33);
            restoreButton.TabIndex = 12;
            restoreButton.Text = "Restore";
            restoreButton.UseVisualStyleBackColor = true;
            restoreButton.Click += restoreButton_Click;
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 266);
            Controls.Add(restoreButton);
            Controls.Add(exitButton);
            Controls.Add(backupNowButton);
            Controls.Add(bkupPathTextBox);
            Controls.Add(label2);
            Name = "BackupForm";
            Text = "BackupForm";
            Load += BackupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox bkupPathTextBox;
        private Button backupNowButton;
        private Button exitButton;
        private Button restoreButton;
    }
}