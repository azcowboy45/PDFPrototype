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
            label9 = new Label();
            subCatComboBox = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            subcategoryTextBox = new TextBox();
            categoryTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "FileName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 219);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 50);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 310);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Creation Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 261);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Size:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 268);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Atributes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 318);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 7;
            label8.Text = "Last Modification:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(36, 10);
            idTextBox.Margin = new Padding(2);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(106, 23);
            idTextBox.TabIndex = 8;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(296, 12);
            fnameTextBox.Margin = new Padding(2);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.ReadOnly = true;
            fnameTextBox.Size = new Size(415, 23);
            fnameTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(87, 219);
            descriptionTextBox.Margin = new Padding(2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(624, 23);
            descriptionTextBox.TabIndex = 11;
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(87, 260);
            fileSizeTextBox.Margin = new Padding(2);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.ReadOnly = true;
            fileSizeTextBox.Size = new Size(141, 23);
            fileSizeTextBox.TabIndex = 12;
            // 
            // creationDateTextBox
            // 
            creationDateTextBox.Location = new Point(87, 308);
            creationDateTextBox.Margin = new Padding(2);
            creationDateTextBox.Name = "creationDateTextBox";
            creationDateTextBox.ReadOnly = true;
            creationDateTextBox.Size = new Size(141, 23);
            creationDateTextBox.TabIndex = 13;
            // 
            // lastModextBox
            // 
            lastModextBox.Location = new Point(557, 317);
            lastModextBox.Margin = new Padding(2);
            lastModextBox.Name = "lastModextBox";
            lastModextBox.ReadOnly = true;
            lastModextBox.Size = new Size(154, 23);
            lastModextBox.TabIndex = 14;
            // 
            // attributeTextBox
            // 
            attributeTextBox.Location = new Point(557, 266);
            attributeTextBox.Margin = new Padding(2);
            attributeTextBox.Name = "attributeTextBox";
            attributeTextBox.ReadOnly = true;
            attributeTextBox.Size = new Size(154, 23);
            attributeTextBox.TabIndex = 15;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(10, 380);
            SaveButton.Margin = new Padding(2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(78, 20);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(631, 380);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 20);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(419, 104);
            categoryComboBox.Margin = new Padding(2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(261, 23);
            categoryComboBox.TabIndex = 18;
            // 
            // editCatButton
            // 
            editCatButton.Location = new Point(296, 380);
            editCatButton.Margin = new Padding(2);
            editCatButton.Name = "editCatButton";
            editCatButton.Size = new Size(120, 20);
            editCatButton.TabIndex = 39;
            editCatButton.Text = "Modify Categories";
            editCatButton.UseVisualStyleBackColor = true;
            editCatButton.Click += editCatButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 87);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 40;
            label9.Text = "Subcategory:";
            // 
            // subCatComboBox
            // 
            subCatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subCatComboBox.FormattingEnabled = true;
            subCatComboBox.Location = new Point(419, 141);
            subCatComboBox.Margin = new Padding(2);
            subCatComboBox.Name = "subCatComboBox";
            subCatComboBox.Size = new Size(261, 23);
            subCatComboBox.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(175, 74);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 42;
            label10.Text = "Current Values";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(492, 74);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 43;
            label11.Text = "New Values";
            label11.Click += label11_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(subcategoryTextBox);
            panel1.Controls.Add(categoryTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 134);
            panel1.TabIndex = 44;
            // 
            // subcategoryTextBox
            // 
            subcategoryTextBox.Location = new Point(113, 82);
            subcategoryTextBox.Name = "subcategoryTextBox";
            subcategoryTextBox.ReadOnly = true;
            subcategoryTextBox.Size = new Size(263, 23);
            subcategoryTextBox.TabIndex = 45;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(113, 47);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(263, 23);
            categoryTextBox.TabIndex = 46;
            // 
            // PDFInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 409);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(subCatComboBox);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "PDFInfoForm";
            Text = "ModifyPDFInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label9;
        private ComboBox subCatComboBox;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private TextBox subcategoryTextBox;
        private TextBox categoryTextBox;
    }
}