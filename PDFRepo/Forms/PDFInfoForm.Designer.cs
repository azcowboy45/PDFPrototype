namespace PDFRepo.Forms
{
    partial class PDFInfoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            idTextBox = new TextBox();
            fnameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            fileSizeTextBox = new TextBox();
            creationDateTextBox = new TextBox();
            lastModextBox = new TextBox();
            attributeTextBox = new TextBox();
            SaveButton = new Button();
            exitButton = new Button();
            categoryComboBox = new ComboBox();
            editCatButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 23);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "FileName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 122);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 250);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 430);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 4;
            label5.Text = "Creation Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 337);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 5;
            label6.Text = "Size:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(689, 334);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 6;
            label7.Text = "Atributes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(638, 430);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 7;
            label8.Text = "Last Modification:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(52, 17);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 8;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(423, 20);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.ReadOnly = true;
            fnameTextBox.Size = new Size(591, 31);
            fnameTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(175, 116);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(839, 31);
            descriptionTextBox.TabIndex = 11;
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(175, 334);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.ReadOnly = true;
            fileSizeTextBox.Size = new Size(200, 31);
            fileSizeTextBox.TabIndex = 12;
            // 
            // creationDateTextBox
            // 
            creationDateTextBox.Location = new Point(175, 427);
            creationDateTextBox.Name = "creationDateTextBox";
            creationDateTextBox.ReadOnly = true;
            creationDateTextBox.Size = new Size(200, 31);
            creationDateTextBox.TabIndex = 13;
            // 
            // lastModextBox
            // 
            lastModextBox.Location = new Point(796, 427);
            lastModextBox.Name = "lastModextBox";
            lastModextBox.ReadOnly = true;
            lastModextBox.Size = new Size(218, 31);
            lastModextBox.TabIndex = 14;
            // 
            // attributeTextBox
            // 
            attributeTextBox.Location = new Point(796, 331);
            attributeTextBox.Name = "attributeTextBox";
            attributeTextBox.ReadOnly = true;
            attributeTextBox.Size = new Size(218, 31);
            attributeTextBox.TabIndex = 15;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 534);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(902, 534);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(373, 247);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(371, 33);
            categoryComboBox.TabIndex = 18;
            // 
            // editCatButton
            // 
            editCatButton.Location = new Point(423, 534);
            editCatButton.Name = "editCatButton";
            editCatButton.Size = new Size(153, 34);
            editCatButton.TabIndex = 39;
            editCatButton.Text = "Edit Categories";
            editCatButton.UseVisualStyleBackColor = true;
            editCatButton.Click += editCatButton_Click;
            // 
            // PDFInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 580);
            Controls.Add(editCatButton);
            Controls.Add(categoryComboBox);
            Controls.Add(exitButton);
            Controls.Add(SaveButton);
            Controls.Add(attributeTextBox);
            Controls.Add(lastModextBox);
            Controls.Add(creationDateTextBox);
            Controls.Add(fileSizeTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(fnameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PDFInfoForm";
            Text = "ModifyPDFInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox idTextBox;
        private TextBox fnameTextBox;
        private TextBox descriptionTextBox;
        private TextBox fileSizeTextBox;
        private TextBox creationDateTextBox;
        private TextBox lastModextBox;
        private TextBox attributeTextBox;
        private Button SaveButton;
        private Button exitButton;
        private ComboBox categoryComboBox;
        private Button editCatButton;
    }
}