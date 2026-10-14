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
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(853, 699);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 699);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // dbPathTextBox
            // 
            dbPathTextBox.Location = new Point(182, 471);
            dbPathTextBox.Name = "dbPathTextBox";
            dbPathTextBox.Size = new Size(779, 31);
            dbPathTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 474);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Path to Database:";
            // 
            // configPathTextBox
            // 
            configPathTextBox.Location = new Point(182, 522);
            configPathTextBox.Name = "configPathTextBox";
            configPathTextBox.Size = new Size(779, 31);
            configPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 525);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 5;
            label2.Text = "Path to Config;";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 358);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(779, 31);
            textBox1.TabIndex = 6;
            textBox1.Text = "It works!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 358);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 7;
            label3.Text = "This will be logged:";
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 745);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(configPathTextBox);
            Controls.Add(label1);
            Controls.Add(dbPathTextBox);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Name = "SetupForm";
            Text = "SetupForm";
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
    }
}