namespace PDFRepo
{
    partial class PDF_list
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            exitButton = new Button();
            ViewButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1787, 907);
            dataGridView1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1573, 1042);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(12, 1042);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(112, 34);
            ViewButton.TabIndex = 2;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            // 
            // PDF_list
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 1075);
            Controls.Add(ViewButton);
            Controls.Add(exitButton);
            Controls.Add(dataGridView1);
            Name = "PDF_list";
            Text = "My PDF LIst";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button exitButton;
        private Button ViewButton;
    }
}
