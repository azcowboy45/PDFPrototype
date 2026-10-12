namespace PDFRepo.Forms
{
    partial class SubCatForm
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
            label3 = new Label();
            label1 = new Label();
            saveButton = new Button();
            exitButton = new Button();
            subCatTextBox = new TextBox();
            notesTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 147);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 222);
            label3.Name = "label3";
            label3.Size = new Size(293, 25);
            label3.TabIndex = 2;
            label3.Text = "Category names must be unique!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 56);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 3;
            label1.Text = "Subcategory:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(37, 305);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(665, 305);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // subCatTextBox
            // 
            subCatTextBox.Location = new Point(203, 55);
            subCatTextBox.Name = "subCatTextBox";
            subCatTextBox.Size = new Size(585, 31);
            subCatTextBox.TabIndex = 6;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(203, 141);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(585, 31);
            notesTextBox.TabIndex = 7;
            // 
            // SubCatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 356);
            Controls.Add(notesTextBox);
            Controls.Add(subCatTextBox);
            Controls.Add(exitButton);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SubCatForm";
            Text = "SubCatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private Button saveButton;
        private Button exitButton;
        private TextBox subCatTextBox;
        private TextBox notesTextBox;
    }
}