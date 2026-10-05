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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            modifyPDFInfoToolStripMenuItem = new ToolStripMenuItem();
            viewPDFToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitButton = new Button();
            ViewButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            modifyPDFRecordsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewPDFToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutPDFRepoToolStripMenuItem = new ToolStripMenuItem();
            pdfImportButton = new Button();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(-2, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1787, 907);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { modifyPDFInfoToolStripMenuItem, viewPDFToolStripMenuItem1, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(179, 100);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // modifyPDFInfoToolStripMenuItem
            // 
            modifyPDFInfoToolStripMenuItem.Name = "modifyPDFInfoToolStripMenuItem";
            modifyPDFInfoToolStripMenuItem.Size = new Size(178, 32);
            modifyPDFInfoToolStripMenuItem.Text = "Modify PDF";
            modifyPDFInfoToolStripMenuItem.Click += modifyPDFInfoToolStripMenuItem_Click;
            // 
            // viewPDFToolStripMenuItem1
            // 
            viewPDFToolStripMenuItem1.Name = "viewPDFToolStripMenuItem1";
            viewPDFToolStripMenuItem1.Size = new Size(178, 32);
            viewPDFToolStripMenuItem1.Text = "View PDF";
            viewPDFToolStripMenuItem1.Click += viewPDFToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(178, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1661, 1025);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(12, 1025);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(112, 34);
            ViewButton.TabIndex = 2;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1785, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, deleteToolStripMenuItem1, backupToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(270, 34);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(270, 34);
            exportToolStripMenuItem.Text = "Export Database";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(270, 34);
            backupToolStripMenuItem.Text = "Backup";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPDFRecordsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // modifyPDFRecordsToolStripMenuItem
            // 
            modifyPDFRecordsToolStripMenuItem.Name = "modifyPDFRecordsToolStripMenuItem";
            modifyPDFRecordsToolStripMenuItem.Size = new Size(245, 34);
            modifyPDFRecordsToolStripMenuItem.Text = "Modify PDF Info";
            modifyPDFRecordsToolStripMenuItem.Click += modifyPDFRecordsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewPDFToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewPDFToolStripMenuItem
            // 
            viewPDFToolStripMenuItem.Name = "viewPDFToolStripMenuItem";
            viewPDFToolStripMenuItem.Size = new Size(188, 34);
            viewPDFToolStripMenuItem.Text = "View PDF";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem1, aboutPDFRepoToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(242, 34);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutPDFRepoToolStripMenuItem
            // 
            aboutPDFRepoToolStripMenuItem.Name = "aboutPDFRepoToolStripMenuItem";
            aboutPDFRepoToolStripMenuItem.Size = new Size(242, 34);
            aboutPDFRepoToolStripMenuItem.Text = "About PDFRepo";
            // 
            // pdfImportButton
            // 
            pdfImportButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pdfImportButton.Location = new Point(761, 1033);
            pdfImportButton.Name = "pdfImportButton";
            pdfImportButton.Size = new Size(194, 34);
            pdfImportButton.TabIndex = 4;
            pdfImportButton.Text = "Import PDF";
            pdfImportButton.UseVisualStyleBackColor = true;
            pdfImportButton.Click += pdfImportButton_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(270, 34);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // PDF_list
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 1079);
            Controls.Add(pdfImportButton);
            Controls.Add(ViewButton);
            Controls.Add(exitButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PDF_list";
            Text = "My PDF LIst";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button exitButton;
        private Button ViewButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem modifyPDFRecordsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutPDFRepoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewPDFToolStripMenuItem;
        private ToolStripMenuItem modifyPDFInfoToolStripMenuItem;
        private ToolStripMenuItem viewPDFToolStripMenuItem1;
        private Button pdfImportButton;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}
