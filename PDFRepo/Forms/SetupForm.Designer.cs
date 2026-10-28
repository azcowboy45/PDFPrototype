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
            enableLoggingCheckBox = new CheckBox();
            bypassOnStartupCheckBox = new CheckBox();
            showLineNumbersCheckBox = new CheckBox();
            label5 = new Label();
            alterBackupPathButton = new Button();
            label6 = new Label();
            label7 = new Label();
            pdfPathTextBox = new TextBox();
            pdfPathButton = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(914, 721);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(21, 721);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dbPathTextBox
            // 
            dbPathTextBox.Location = new Point(205, 610);
            dbPathTextBox.Name = "dbPathTextBox";
            dbPathTextBox.ReadOnly = true;
            dbPathTextBox.Size = new Size(779, 31);
            dbPathTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 616);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Path to Database:";
            // 
            // bkupPathTextBox
            // 
            bkupPathTextBox.Location = new Point(176, 464);
            bkupPathTextBox.Name = "bkupPathTextBox";
            bkupPathTextBox.Size = new Size(808, 31);
            bkupPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 467);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 5;
            label2.Text = "Backup Path:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(659, 111);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(354, 31);
            lastNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 114);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 7;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 114);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(169, 111);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(336, 31);
            firstNameTextBox.TabIndex = 9;
            // 
            // enableLoggingCheckBox
            // 
            enableLoggingCheckBox.AutoSize = true;
            enableLoggingCheckBox.Checked = true;
            enableLoggingCheckBox.CheckState = CheckState.Checked;
            enableLoggingCheckBox.Location = new Point(442, 195);
            enableLoggingCheckBox.Name = "enableLoggingCheckBox";
            enableLoggingCheckBox.Size = new Size(172, 29);
            enableLoggingCheckBox.TabIndex = 0;
            enableLoggingCheckBox.Text = "Logging enabled";
            enableLoggingCheckBox.UseVisualStyleBackColor = true;
            enableLoggingCheckBox.CheckedChanged += enableLoggingCheckBox_CheckedChanged;
            // 
            // bypassOnStartupCheckBox
            // 
            bypassOnStartupCheckBox.AutoSize = true;
            bypassOnStartupCheckBox.Checked = true;
            bypassOnStartupCheckBox.CheckState = CheckState.Checked;
            bypassOnStartupCheckBox.Location = new Point(169, 195);
            bypassOnStartupCheckBox.Name = "bypassOnStartupCheckBox";
            bypassOnStartupCheckBox.Size = new Size(229, 29);
            bypassOnStartupCheckBox.TabIndex = 13;
            bypassOnStartupCheckBox.Text = "Bypass setup on startup";
            bypassOnStartupCheckBox.UseVisualStyleBackColor = true;
            bypassOnStartupCheckBox.CheckedChanged += bypassOnStartupCheckBox_CheckedChanged;
            // 
            // showLineNumbersCheckBox
            // 
            showLineNumbersCheckBox.AutoSize = true;
            showLineNumbersCheckBox.Checked = true;
            showLineNumbersCheckBox.CheckState = CheckState.Checked;
            showLineNumbersCheckBox.Location = new Point(659, 195);
            showLineNumbersCheckBox.Name = "showLineNumbersCheckBox";
            showLineNumbersCheckBox.Size = new Size(189, 29);
            showLineNumbersCheckBox.TabIndex = 14;
            showLineNumbersCheckBox.Text = "Show line numbers";
            showLineNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(102, 40);
            label5.Name = "label5";
            label5.Size = new Size(815, 64);
            label5.TabIndex = 15;
            label5.Text = "APPLICATION RESTART REQUIRED FOR THESE CHANGES TO TAKE EFFECT\r\n\r\n";
            label5.Click += label5_Click;
            // 
            // alterBackupPathButton
            // 
            alterBackupPathButton.Location = new Point(757, 398);
            alterBackupPathButton.Name = "alterBackupPathButton";
            alterBackupPathButton.Size = new Size(227, 34);
            alterBackupPathButton.TabIndex = 16;
            alterBackupPathButton.Text = "Change Backup Path";
            alterBackupPathButton.UseVisualStyleBackColor = true;
            alterBackupPathButton.Click += alterBackupPathButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 403);
            label6.Name = "label6";
            label6.Size = new Size(718, 25);
            label6.TabIndex = 17;
            label6.Text = "It is strongly recommend that if you select a new backup folder that it reside in the cloud!\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 269);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 18;
            label7.Text = "Default Path to PDFs:";
            // 
            // pdfPathTextBox
            // 
            pdfPathTextBox.Location = new Point(43, 315);
            pdfPathTextBox.Name = "pdfPathTextBox";
            pdfPathTextBox.Size = new Size(941, 31);
            pdfPathTextBox.TabIndex = 19;
            // 
            // pdfPathButton
            // 
            pdfPathButton.Location = new Point(757, 260);
            pdfPathButton.Name = "pdfPathButton";
            pdfPathButton.Size = new Size(227, 34);
            pdfPathButton.TabIndex = 20;
            pdfPathButton.Text = "Change PDF Search Path";
            pdfPathButton.UseVisualStyleBackColor = true;
            pdfPathButton.Click += pdfPathButton_Click;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 762);
            Controls.Add(pdfPathButton);
            Controls.Add(pdfPathTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(alterBackupPathButton);
            Controls.Add(label5);
            Controls.Add(showLineNumbersCheckBox);
            Controls.Add(enableLoggingCheckBox);
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
            Name = "SetupForm";
            Text = "SetupForm";
            Load += SetupForm_Load;
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
        private CheckBox enableLoggingCheckBox;
        private CheckBox bypassOnStartupCheckBox;
        private CheckBox showLineNumbersCheckBox;
        private Label label5;
        private Button alterBackupPathButton;
        private Label label6;
        private Label label7;
        private TextBox pdfPathTextBox;
        private Button pdfPathButton;
    }
}