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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_list));
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewPDFToolStripMenuItem1 = new ToolStripMenuItem();
            modifyPDFInfoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            editSubCatsToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            modifyPDFRecordsToolStripMenuItem = new ToolStripMenuItem();
            maintainCategoriesToolStripMenuItem = new ToolStripMenuItem();
            subCategoriesToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewPDFToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutPDFRepoToolStripMenuItem = new ToolStripMenuItem();
            pdfImportButton = new Button();
            sqliteConnection1 = new Microsoft.Data.Sqlite.SqliteConnection();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            sqliteConnection2 = new Microsoft.Data.Sqlite.SqliteConnection();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            showAllButton = new Button();
            label2 = new Label();
            subCatComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1773, 974);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewPDFToolStripMenuItem1, modifyPDFInfoToolStripMenuItem, toolStripSeparator2, categoriesToolStripMenuItem, editSubCatsToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(232, 170);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // viewPDFToolStripMenuItem1
            // 
            viewPDFToolStripMenuItem1.Name = "viewPDFToolStripMenuItem1";
            viewPDFToolStripMenuItem1.Size = new Size(231, 32);
            viewPDFToolStripMenuItem1.Text = "View PDF";
            viewPDFToolStripMenuItem1.Click += viewPDFToolStripMenuItem1_Click;
            // 
            // modifyPDFInfoToolStripMenuItem
            // 
            modifyPDFInfoToolStripMenuItem.Name = "modifyPDFInfoToolStripMenuItem";
            modifyPDFInfoToolStripMenuItem.Size = new Size(231, 32);
            modifyPDFInfoToolStripMenuItem.Text = "Edit PDF Info";
            modifyPDFInfoToolStripMenuItem.Click += modifyPDFInfoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(228, 6);
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(231, 32);
            categoriesToolStripMenuItem.Text = "Edit Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // editSubCatsToolStripMenuItem
            // 
            editSubCatsToolStripMenuItem.Name = "editSubCatsToolStripMenuItem";
            editSubCatsToolStripMenuItem.Size = new Size(231, 32);
            editSubCatsToolStripMenuItem.Text = "Edit Subcategories";
            editSubCatsToolStripMenuItem.Click += editSubCatsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(231, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1661, 1107);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
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
            importToolStripMenuItem.Size = new Size(244, 34);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(244, 34);
            exportToolStripMenuItem.Text = "Export Database";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(244, 34);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(244, 34);
            backupToolStripMenuItem.Text = "Backup";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(241, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(244, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPDFRecordsToolStripMenuItem, maintainCategoriesToolStripMenuItem, subCategoriesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // modifyPDFRecordsToolStripMenuItem
            // 
            modifyPDFRecordsToolStripMenuItem.Name = "modifyPDFRecordsToolStripMenuItem";
            modifyPDFRecordsToolStripMenuItem.Size = new Size(226, 34);
            modifyPDFRecordsToolStripMenuItem.Text = "Metadata";
            modifyPDFRecordsToolStripMenuItem.Click += modifyPDFRecordsToolStripMenuItem_Click;
            // 
            // maintainCategoriesToolStripMenuItem
            // 
            maintainCategoriesToolStripMenuItem.Name = "maintainCategoriesToolStripMenuItem";
            maintainCategoriesToolStripMenuItem.Size = new Size(226, 34);
            maintainCategoriesToolStripMenuItem.Text = "Categories";
            maintainCategoriesToolStripMenuItem.Click += maintainCategoriesToolStripMenuItem_Click;
            // 
            // subCategoriesToolStripMenuItem
            // 
            subCategoriesToolStripMenuItem.Name = "subCategoriesToolStripMenuItem";
            subCategoriesToolStripMenuItem.Size = new Size(226, 34);
            subCategoriesToolStripMenuItem.Text = "Subcategories";
            subCategoriesToolStripMenuItem.Click += subCategoriesToolStripMenuItem_Click;
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
            viewPDFToolStripMenuItem.Click += viewPDFToolStripMenuItem_Click;
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
            pdfImportButton.Anchor = AnchorStyles.None;
            pdfImportButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pdfImportButton.Location = new Point(264, 6);
            pdfImportButton.Name = "pdfImportButton";
            pdfImportButton.Size = new Size(194, 34);
            pdfImportButton.TabIndex = 4;
            pdfImportButton.Text = "Import PDF";
            pdfImportButton.UseVisualStyleBackColor = true;
            pdfImportButton.Click += pdfImportButton_Click;
            // 
            // sqliteConnection1
            // 
            sqliteConnection1.DefaultTimeout = 30;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // sqliteConnection2
            // 
            sqliteConnection2.DefaultTimeout = 30;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(770, 51);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(233, 33);
            categoryComboBox.TabIndex = 5;
            categoryComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 54);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 6;
            label1.Text = "Show by Category:";
            // 
            // showAllButton
            // 
            showAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showAllButton.FlatStyle = FlatStyle.Popup;
            showAllButton.Location = new Point(1646, 5);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(112, 34);
            showAllButton.TabIndex = 7;
            showAllButton.Text = "Show All";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1044, 54);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 8;
            label2.Text = "Subcategory:";
            // 
            // subCatComboBox
            // 
            subCatComboBox.FormattingEnabled = true;
            subCatComboBox.Location = new Point(1166, 51);
            subCatComboBox.Name = "subCatComboBox";
            subCatComboBox.Size = new Size(233, 33);
            subCatComboBox.TabIndex = 9;
            subCatComboBox.SelectedIndexChanged += subCatComboBox_SelectedIndexChanged;
            // 
            // PDF_list
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 1153);
            Controls.Add(subCatComboBox);
            Controls.Add(label2);
            Controls.Add(showAllButton);
            Controls.Add(label1);
            Controls.Add(categoryComboBox);
            Controls.Add(pdfImportButton);
            Controls.Add(exitButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem maintainCategoriesToolStripMenuItem;
        private Microsoft.Data.Sqlite.SqliteConnection sqliteConnection1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Microsoft.Data.Sqlite.SqliteConnection sqliteConnection2;
        private ComboBox categoryComboBox;
        private Label label1;
        private Button showAllButton;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem editSubCatsToolStripMenuItem;
        private ToolStripMenuItem subCategoriesToolStripMenuItem;
        private Label label2;
        private ComboBox subCatComboBox;
        private ToolStripSeparator toolStripSeparator2;
    }
}
