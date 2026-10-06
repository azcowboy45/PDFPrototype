namespace PDFRepo.Forms
{
    partial class CategoryInputForm
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
            categoryTextBox = new TextBox();
            notesTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(579, 243);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            saveButton.Location = new Point(12, 243);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(124, 49);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(567, 31);
            categoryTextBox.TabIndex = 3;
            // 
            // notesTextbox
            // 
            notesTextbox.Location = new Point(124, 119);
            notesTextbox.Name = "notesTextbox";
            notesTextbox.Size = new Size(567, 31);
            notesTextbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 5;
            label1.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 122);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 195);
            label3.Name = "label3";
            label3.Size = new Size(293, 25);
            label3.TabIndex = 7;
            label3.Text = "Category names must be unique!";
            // 
            // CategoryInputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(notesTextbox);
            Controls.Add(categoryTextBox);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Name = "CategoryInputForm";
            Text = "CategoryInputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button saveButton;
        private TextBox categoryTextBox;
        private TextBox notesTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}