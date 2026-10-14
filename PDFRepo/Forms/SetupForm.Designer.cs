namespace PDFRepo.Forms
{
    partial class SetupForm
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
            exitButton = new Button();
            saveButton = new Button();
            dbPathTextBox = new TextBox();
            label1 = new Label();
            bkupPathTextBox = new TextBox();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            firstNameTextBox = new TextBox();
            panel1 = new Panel();
            enableLoggingCheckBox = new CheckBox();
            bypassOnStartupCheckBox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(872, 387);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(21, 382);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dbPathTextBox
            // 
            dbPathTextBox.Location = new Point(205, 256);
            dbPathTextBox.Name = "dbPathTextBox";
            dbPathTextBox.Size = new Size(779, 31);
            dbPathTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 262);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Path to Database:";
            // 
            // bkupPathTextBox
            // 
            bkupPathTextBox.Location = new Point(205, 162);
            bkupPathTextBox.Name = "bkupPathTextBox";
            bkupPathTextBox.Size = new Size(779, 31);
            bkupPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 165);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 5;
            label2.Text = "Backup Path:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(648, 80);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(336, 31);
            lastNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 83);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 7;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 83);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(169, 80);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(336, 31);
            firstNameTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(enableLoggingCheckBox);
            panel1.Location = new Point(12, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 105);
            panel1.TabIndex = 12;
            // 
            // enableLoggingCheckBox
            // 
            enableLoggingCheckBox.AutoSize = true;
            enableLoggingCheckBox.Checked = true;
            enableLoggingCheckBox.CheckState = CheckState.Checked;
            enableLoggingCheckBox.Location = new Point(193, 67);
            enableLoggingCheckBox.Name = "enableLoggingCheckBox";
            enableLoggingCheckBox.Size = new Size(130, 29);
            enableLoggingCheckBox.TabIndex = 0;
            enableLoggingCheckBox.Text = "Logging on";
            enableLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // bypassOnStartupCheckBox
            // 
            bypassOnStartupCheckBox.AutoSize = true;
            bypassOnStartupCheckBox.Checked = true;
            bypassOnStartupCheckBox.CheckState = CheckState.Checked;
            bypassOnStartupCheckBox.Location = new Point(436, 387);
            bypassOnStartupCheckBox.Name = "bypassOnStartupCheckBox";
            bypassOnStartupCheckBox.Size = new Size(180, 29);
            bypassOnStartupCheckBox.TabIndex = 13;
            bypassOnStartupCheckBox.Text = "Bypass on startup";
            bypassOnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 438);
            Controls.Add(bypassOnStartupCheckBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(bkupPathTextBox);
            Controls.Add(label1);
            Controls.Add(dbPathTextBox);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Name = "SetupForm";
            Text = "SetupForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button saveButton;
        private TextBox dbPathTextBox;
        private Label label1;
        private TextBox bkupPathTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private Label label4;
        private TextBox firstNameTextBox;
        private Panel panel1;
        private CheckBox enableLoggingCheckBox;
        private CheckBox bypassOnStartupCheckBox;
    }
}