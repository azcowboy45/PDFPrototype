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
            saveButton = new Button();
            modifyBkupPathButton = new Button();
            backupNowButton = new Button();
            exitButton = new Button();
            restoreButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Backup Path:";
            // 
            // bkupPathTextBox
            // 
            bkupPathTextBox.Location = new Point(8, 112);
            bkupPathTextBox.Margin = new Padding(2, 2, 2, 2);
            bkupPathTextBox.Name = "bkupPathTextBox";
            bkupPathTextBox.Size = new Size(673, 23);
            bkupPathTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(8, 176);
            saveButton.Margin = new Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 20);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // modifyBkupPathButton
            // 
            modifyBkupPathButton.Location = new Point(561, 80);
            modifyBkupPathButton.Margin = new Padding(2, 2, 2, 2);
            modifyBkupPathButton.Name = "modifyBkupPathButton";
            modifyBkupPathButton.Size = new Size(120, 20);
            modifyBkupPathButton.TabIndex = 9;
            modifyBkupPathButton.Text = "New Backup Path";
            modifyBkupPathButton.UseVisualStyleBackColor = true;
            modifyBkupPathButton.Click += modifyBkupPathButton_Click;
            // 
            // backupNowButton
            // 
            backupNowButton.Location = new Point(8, 7);
            backupNowButton.Margin = new Padding(2, 2, 2, 2);
            backupNowButton.Name = "backupNowButton";
            backupNowButton.Size = new Size(120, 20);
            backupNowButton.TabIndex = 10;
            backupNowButton.Text = "Backup";
            backupNowButton.UseVisualStyleBackColor = true;
            backupNowButton.Click += backupNowButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(561, 176);
            exitButton.Margin = new Padding(2, 2, 2, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(120, 20);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restoreButton
            // 
            restoreButton.Location = new Point(561, 7);
            restoreButton.Margin = new Padding(2, 2, 2, 2);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(120, 20);
            restoreButton.TabIndex = 12;
            restoreButton.Text = "Restore";
            restoreButton.UseVisualStyleBackColor = true;
            restoreButton.Click += restoreButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 40);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 13;
            label1.Text = "Form inactive. Draft!";
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 205);
            Controls.Add(label1);
            Controls.Add(restoreButton);
            Controls.Add(exitButton);
            Controls.Add(backupNowButton);
            Controls.Add(modifyBkupPathButton);
            Controls.Add(saveButton);
            Controls.Add(bkupPathTextBox);
            Controls.Add(label2);
            Enabled = false;
            Margin = new Padding(2, 2, 2, 2);
            Name = "BackupForm";
            Text = "BackupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox bkupPathTextBox;
        private Button saveButton;
        private Button modifyBkupPathButton;
        private Button backupNowButton;
        private Button exitButton;
        private Button restoreButton;
        private Label label1;
    }
}