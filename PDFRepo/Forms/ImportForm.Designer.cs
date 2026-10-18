namespace PDFRepo.Forms
{
    partial class ImportForm
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
            importButton = new Button();
            selectPDFButton = new Button();
            editCatButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pdfPathTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            fileSizeTextBox = new TextBox();
            creationDateTextBox = new TextBox();
            lastModextBox = new TextBox();
            attributeTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            label9 = new Label();
            subCatComboBox = new ComboBox();
            editSubcategoriesButton = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(987, 590);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 35;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // importButton
            // 
            importButton.Enabled = false;
            importButton.Location = new Point(45, 590);
            importButton.Name = "importButton";
            importButton.Size = new Size(112, 34);
            importButton.TabIndex = 34;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // selectPDFButton
            // 
            selectPDFButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectPDFButton.Location = new Point(12, 12);
            selectPDFButton.Name = "selectPDFButton";
            selectPDFButton.Size = new Size(256, 44);
            selectPDFButton.TabIndex = 36;
            selectPDFButton.Text = "Find a PDF For Import";
            selectPDFButton.UseVisualStyleBackColor = true;
            selectPDFButton.Click += selectPDFButton_Click;
            // 
            // editCatButton
            // 
            editCatButton.Location = new Point(397, 590);
            editCatButton.Name = "editCatButton";
            editCatButton.Size = new Size(172, 34);
            editCatButton.TabIndex = 38;
            editCatButton.Text = "Edit Categories";
            editCatButton.UseVisualStyleBackColor = true;
            editCatButton.Click += editCatButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 86);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 19;
            label2.Text = "PDF Path:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 202);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 20;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 319);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 21;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 481);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 22;
            label5.Text = "Creation Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 420);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 23;
            label6.Text = "Size:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(709, 420);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 24;
            label7.Text = "Atributes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 481);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 25;
            label8.Text = "Last Modification:";
            // 
            // pdfPathTextBox
            // 
            pdfPathTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdfPathTextBox.Location = new Point(191, 83);
            pdfPathTextBox.Multiline = true;
            pdfPathTextBox.Name = "pdfPathTextBox";
            pdfPathTextBox.ReadOnly = true;
            pdfPathTextBox.Size = new Size(839, 72);
            pdfPathTextBox.TabIndex = 27;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(193, 199);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(839, 75);
            descriptionTextBox.TabIndex = 29;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(193, 417);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.ReadOnly = true;
            fileSizeTextBox.Size = new Size(200, 31);
            fileSizeTextBox.TabIndex = 30;
            // 
            // creationDateTextBox
            // 
            creationDateTextBox.Location = new Point(196, 478);
            creationDateTextBox.Name = "creationDateTextBox";
            creationDateTextBox.ReadOnly = true;
            creationDateTextBox.Size = new Size(200, 31);
            creationDateTextBox.TabIndex = 31;
            // 
            // lastModextBox
            // 
            lastModextBox.Location = new Point(817, 478);
            lastModextBox.Name = "lastModextBox";
            lastModextBox.ReadOnly = true;
            lastModextBox.Size = new Size(218, 31);
            lastModextBox.TabIndex = 32;
            // 
            // attributeTextBox
            // 
            attributeTextBox.Location = new Point(817, 420);
            attributeTextBox.Name = "attributeTextBox";
            attributeTextBox.ReadOnly = true;
            attributeTextBox.Size = new Size(218, 31);
            attributeTextBox.TabIndex = 33;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(441, 316);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(293, 33);
            categoryComboBox.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 375);
            label9.Name = "label9";
            label9.Size = new Size(116, 25);
            label9.TabIndex = 39;
            label9.Text = "Subcategory:";
            // 
            // subCatComboBox
            // 
            subCatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subCatComboBox.FormattingEnabled = true;
            subCatComboBox.Location = new Point(441, 372);
            subCatComboBox.Name = "subCatComboBox";
            subCatComboBox.Size = new Size(293, 33);
            subCatComboBox.TabIndex = 40;
            subCatComboBox.SelectedIndexChanged += subCatComboBox_SelectedIndexChanged;
            // 
            // editSubcategoriesButton
            // 
            editSubcategoriesButton.Location = new Point(607, 590);
            editSubcategoriesButton.Name = "editSubcategoriesButton";
            editSubcategoriesButton.Size = new Size(172, 34);
            editSubcategoriesButton.TabIndex = 41;
            editSubcategoriesButton.Text = "Edit Subcategories";
            editSubcategoriesButton.UseVisualStyleBackColor = true;
            editSubcategoriesButton.Click += editSubcategoriesButton_Click;
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 649);
            Controls.Add(editSubcategoriesButton);
            Controls.Add(subCatComboBox);
            Controls.Add(label9);
            Controls.Add(categoryComboBox);
            Controls.Add(editCatButton);
            Controls.Add(attributeTextBox);
            Controls.Add(lastModextBox);
            Controls.Add(selectPDFButton);
            Controls.Add(creationDateTextBox);
            Controls.Add(exitButton);
            Controls.Add(fileSizeTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(importButton);
            Controls.Add(pdfPathTextBox);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "ImportForm";
            Text = "ImportForm";
            Activated += ImportForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitButton;
        private Button importButton;
        private Button selectPDFButton;
        private Button editCatButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox pdfPathTextBox;
        private TextBox descriptionTextBox;
        private TextBox fileSizeTextBox;
        private TextBox creationDateTextBox;
        private TextBox lastModextBox;
        private TextBox attributeTextBox;
        private ComboBox categoryComboBox;
        private Label label9;
        private ComboBox subCatComboBox;
        private Button editSubcategoriesButton;
    }
}