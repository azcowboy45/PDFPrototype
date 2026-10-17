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
            toolStripSeparator3 = new ToolStripSeparator();
            setupToolStripMenuItem = new ToolStripMenuItem();
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
            userNameTextBox = new TextBox();
            label3 = new Label();
            selectorComboBox = new ComboBox();
            label4 = new Label();
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
            dataGridView1.Location = new Point(8, 63);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1241, 584);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewPDFToolStripMenuItem1, modifyPDFInfoToolStripMenuItem, toolStripSeparator2, categoriesToolStripMenuItem, editSubCatsToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 120);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // viewPDFToolStripMenuItem1
            // 
            viewPDFToolStripMenuItem1.Name = "viewPDFToolStripMenuItem1";
            viewPDFToolStripMenuItem1.Size = new Size(171, 22);
            viewPDFToolStripMenuItem1.Text = "View PDF";
            viewPDFToolStripMenuItem1.Click += viewPDFToolStripMenuItem1_Click;
            // 
            // modifyPDFInfoToolStripMenuItem
            // 
            modifyPDFInfoToolStripMenuItem.Name = "modifyPDFInfoToolStripMenuItem";
            modifyPDFInfoToolStripMenuItem.Size = new Size(171, 22);
            modifyPDFInfoToolStripMenuItem.Text = "Edit PDF Info";
            modifyPDFInfoToolStripMenuItem.Click += modifyPDFInfoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(168, 6);
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(171, 22);
            categoriesToolStripMenuItem.Text = "Edit Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // editSubCatsToolStripMenuItem
            // 
            editSubCatsToolStripMenuItem.Name = "editSubCatsToolStripMenuItem";
            editSubCatsToolStripMenuItem.Size = new Size(171, 22);
            editSubCatsToolStripMenuItem.Text = "Edit Subcategories";
            editSubCatsToolStripMenuItem.Click += editSubCatsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(171, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1163, 664);
            exitButton.Margin = new Padding(2, 2, 2, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 20);
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
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1250, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, deleteToolStripMenuItem1, backupToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(158, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(158, 22);
            exportToolStripMenuItem.Text = "Export Database";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(158, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(158, 22);
            backupToolStripMenuItem.Text = "Backup";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPDFRecordsToolStripMenuItem, maintainCategoriesToolStripMenuItem, subCategoriesToolStripMenuItem, toolStripSeparator3, setupToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // modifyPDFRecordsToolStripMenuItem
            // 
            modifyPDFRecordsToolStripMenuItem.Name = "modifyPDFRecordsToolStripMenuItem";
            modifyPDFRecordsToolStripMenuItem.Size = new Size(148, 22);
            modifyPDFRecordsToolStripMenuItem.Text = "Metadata";
            modifyPDFRecordsToolStripMenuItem.Click += modifyPDFRecordsToolStripMenuItem_Click;
            // 
            // maintainCategoriesToolStripMenuItem
            // 
            maintainCategoriesToolStripMenuItem.Name = "maintainCategoriesToolStripMenuItem";
            maintainCategoriesToolStripMenuItem.Size = new Size(148, 22);
            maintainCategoriesToolStripMenuItem.Text = "Categories";
            maintainCategoriesToolStripMenuItem.Click += maintainCategoriesToolStripMenuItem_Click;
            // 
            // subCategoriesToolStripMenuItem
            // 
            subCategoriesToolStripMenuItem.Name = "subCategoriesToolStripMenuItem";
            subCategoriesToolStripMenuItem.Size = new Size(148, 22);
            subCategoriesToolStripMenuItem.Text = "Subcategories";
            subCategoriesToolStripMenuItem.Click += subCategoriesToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(145, 6);
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(148, 22);
            setupToolStripMenuItem.Text = "Setup";
            setupToolStripMenuItem.Click += setupToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewPDFToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 22);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewPDFToolStripMenuItem
            // 
            viewPDFToolStripMenuItem.Name = "viewPDFToolStripMenuItem";
            viewPDFToolStripMenuItem.Size = new Size(123, 22);
            viewPDFToolStripMenuItem.Text = "View PDF";
            viewPDFToolStripMenuItem.Click += viewPDFToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem1, aboutPDFRepoToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(158, 22);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutPDFRepoToolStripMenuItem
            // 
            aboutPDFRepoToolStripMenuItem.Name = "aboutPDFRepoToolStripMenuItem";
            aboutPDFRepoToolStripMenuItem.Size = new Size(158, 22);
            aboutPDFRepoToolStripMenuItem.Text = "About PDFRepo";
            // 
            // pdfImportButton
            // 
            pdfImportButton.Anchor = AnchorStyles.None;
            pdfImportButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pdfImportButton.Location = new Point(185, 4);
            pdfImportButton.Margin = new Padding(2, 2, 2, 2);
            pdfImportButton.Name = "pdfImportButton";
            pdfImportButton.Size = new Size(136, 20);
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
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(676, 35);
            categoryComboBox.Margin = new Padding(2, 2, 2, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(164, 23);
            categoryComboBox.TabIndex = 5;
            categoryComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 6;
            label1.Text = "Show by Category:";
            // 
            // showAllButton
            // 
            showAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showAllButton.FlatStyle = FlatStyle.Popup;
            showAllButton.Location = new Point(1152, 3);
            showAllButton.Margin = new Padding(2, 2, 2, 2);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(78, 20);
            showAllButton.TabIndex = 7;
            showAllButton.Text = "Show All";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(853, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 8;
            label2.Text = "Subcategory:";
            // 
            // subCatComboBox
            // 
            subCatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subCatComboBox.FormattingEnabled = true;
            subCatComboBox.Location = new Point(960, 35);
            subCatComboBox.Margin = new Padding(2, 2, 2, 2);
            subCatComboBox.Name = "subCatComboBox";
            subCatComboBox.Size = new Size(164, 23);
            subCatComboBox.TabIndex = 9;
            subCatComboBox.SelectedIndexChanged += subCatComboBox_SelectedIndexChanged;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(101, 666);
            userNameTextBox.Margin = new Padding(2, 2, 2, 2);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.ReadOnly = true;
            userNameTextBox.Size = new Size(159, 23);
            userNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 667);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "Repository for:";
            // 
            // selectorComboBox
            // 
            selectorComboBox.FormattingEnabled = true;
            selectorComboBox.Location = new Point(110, 32);
            selectorComboBox.Margin = new Padding(2, 2, 2, 2);
            selectorComboBox.Name = "selectorComboBox";
            selectorComboBox.Size = new Size(253, 23);
            selectorComboBox.TabIndex = 12;
            selectorComboBox.SelectedIndexChanged += selectorComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 13;
            label4.Text = "Select by Name:";
            // 
            // PDF_list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 666);
            Controls.Add(label4);
            Controls.Add(selectorComboBox);
            Controls.Add(label3);
            Controls.Add(userNameTextBox);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem setupToolStripMenuItem;
        private TextBox userNameTextBox;
        private Label label3;
        private ComboBox selectorComboBox;
        private Label label4;
    }
}
