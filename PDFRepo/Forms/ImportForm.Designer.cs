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
            panel1 = new Panel();
            categoryComboBox = new ComboBox();
            attributeTextBox = new TextBox();
            lastModextBox = new TextBox();
            creationDateTextBox = new TextBox();
            fileSizeTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            pdfPathTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            exitButton = new Button();
            importButton = new Button();
            selectPDFButton = new Button();
            label1 = new Label();
            editCatButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(attributeTextBox);
            panel1.Controls.Add(lastModextBox);
            panel1.Controls.Add(creationDateTextBox);
            panel1.Controls.Add(fileSizeTextBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(pdfPathTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(48, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 562);
            panel1.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(422, 276);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(293, 33);
            categoryComboBox.TabIndex = 34;
            // 
            // attributeTextBox
            // 
            attributeTextBox.Location = new Point(795, 360);
            attributeTextBox.Name = "attributeTextBox";
            attributeTextBox.ReadOnly = true;
            attributeTextBox.Size = new Size(218, 31);
            attributeTextBox.TabIndex = 33;
            // 
            // lastModextBox
            // 
            lastModextBox.Location = new Point(795, 456);
            lastModextBox.Name = "lastModextBox";
            lastModextBox.ReadOnly = true;
            lastModextBox.Size = new Size(218, 31);
            lastModextBox.TabIndex = 32;
            // 
            // creationDateTextBox
            // 
            creationDateTextBox.Location = new Point(174, 456);
            creationDateTextBox.Name = "creationDateTextBox";
            creationDateTextBox.ReadOnly = true;
            creationDateTextBox.Size = new Size(200, 31);
            creationDateTextBox.TabIndex = 31;
            // 
            // fileSizeTextBox
            // 
            fileSizeTextBox.Location = new Point(174, 363);
            fileSizeTextBox.Name = "fileSizeTextBox";
            fileSizeTextBox.ReadOnly = true;
            fileSizeTextBox.Size = new Size(200, 31);
            fileSizeTextBox.TabIndex = 30;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(174, 145);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(839, 75);
            descriptionTextBox.TabIndex = 29;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // pdfPathTextBox
            // 
            pdfPathTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdfPathTextBox.Location = new Point(172, 29);
            pdfPathTextBox.Multiline = true;
            pdfPathTextBox.Name = "pdfPathTextBox";
            pdfPathTextBox.ReadOnly = true;
            pdfPathTextBox.Size = new Size(839, 72);
            pdfPathTextBox.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(637, 459);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 25;
            label8.Text = "Last Modification:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(688, 363);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 24;
            label7.Text = "Atributes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 366);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 23;
            label6.Text = "Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 459);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 22;
            label5.Text = "Creation Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 279);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 21;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 148);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 20;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 32);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 19;
            label2.Text = "PDF Path:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(990, 674);
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
            importButton.Location = new Point(48, 674);
            importButton.Name = "importButton";
            importButton.Size = new Size(112, 34);
            importButton.TabIndex = 34;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // selectPDFButton
            // 
            selectPDFButton.Location = new Point(213, 12);
            selectPDFButton.Name = "selectPDFButton";
            selectPDFButton.Size = new Size(117, 34);
            selectPDFButton.TabIndex = 36;
            selectPDFButton.Text = "Get PDF";
            selectPDFButton.UseVisualStyleBackColor = true;
            selectPDFButton.Click += selectPDFButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 17);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 37;
            label1.Text = "Find a PDF to add:";
            // 
            // editCatButton
            // 
            editCatButton.Location = new Point(470, 674);
            editCatButton.Name = "editCatButton";
            editCatButton.Size = new Size(153, 34);
            editCatButton.TabIndex = 38;
            editCatButton.Text = "Edit Categories";
            editCatButton.UseVisualStyleBackColor = true;
            editCatButton.Click += editCatButton_Click;
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 736);
            Controls.Add(editCatButton);
            Controls.Add(label1);
            Controls.Add(selectPDFButton);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(importButton);
            Name = "ImportForm";
            Text = "ImportForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox attributeTextBox;
        private TextBox lastModextBox;
        private TextBox creationDateTextBox;
        private TextBox fileSizeTextBox;
        private TextBox descriptionTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button exitButton;
        private Button importButton;
        private Button selectPDFButton;
        private TextBox pdfPathTextBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Button editCatButton;
    }
}