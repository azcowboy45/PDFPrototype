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
            configPathTextBox = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            bypassCheckBox = new CheckBox();
            loggingCheckBox = new CheckBox();
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
            // configPathTextBox
            // 
            configPathTextBox.Location = new Point(205, 162);
            configPathTextBox.Name = "configPathTextBox";
            configPathTextBox.Size = new Size(779, 31);
            configPathTextBox.TabIndex = 4;
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
            // textBox1
            // 
            textBox1.Location = new Point(648, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 31);
            textBox1.TabIndex = 6;
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
            // textBox2
            // 
            textBox2.Location = new Point(169, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 31);
            textBox2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(loggingCheckBox);
            panel1.Location = new Point(12, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 105);
            panel1.TabIndex = 12;
            // 
            // bypassCheckBox
            // 
            bypassCheckBox.AutoSize = true;
            bypassCheckBox.Location = new Point(439, 387);
            bypassCheckBox.Name = "bypassCheckBox";
            bypassCheckBox.Size = new Size(180, 29);
            bypassCheckBox.TabIndex = 13;
            bypassCheckBox.Text = "Bypass on startup";
            bypassCheckBox.UseVisualStyleBackColor = true;
            // 
            // loggingCheckBox
            // 
            loggingCheckBox.AutoSize = true;
            loggingCheckBox.Location = new Point(193, 67);
            loggingCheckBox.Name = "loggingCheckBox";
            loggingCheckBox.Size = new Size(130, 29);
            loggingCheckBox.TabIndex = 0;
            loggingCheckBox.Text = "Logging on";
            loggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 468);
            Controls.Add(bypassCheckBox);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(configPathTextBox);
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
        private TextBox configPathTextBox;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Panel panel1;
        private CheckBox loggingCheckBox;
        private CheckBox bypassCheckBox;
    }
}