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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            pdfCountTextBox = new TextBox();
            label6 = new Label();
            gotToEndButton = new Button();
            firstRowButton = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1784, 1026);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewPDFToolStripMenuItem1, modifyPDFInfoToolStripMenuItem, toolStripSeparator2, categoriesToolStripMenuItem, editSubCatsToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(243, 170);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // viewPDFToolStripMenuItem1
            // 
            viewPDFToolStripMenuItem1.Name = "viewPDFToolStripMenuItem1";
            viewPDFToolStripMenuItem1.Size = new Size(242, 32);
            viewPDFToolStripMenuItem1.Text = "View PDF";
            viewPDFToolStripMenuItem1.Click += viewPDFToolStripMenuItem1_Click;
            // 
            // modifyPDFInfoToolStripMenuItem
            // 
            modifyPDFInfoToolStripMenuItem.Name = "modifyPDFInfoToolStripMenuItem";
            modifyPDFInfoToolStripMenuItem.Size = new Size(242, 32);
            modifyPDFInfoToolStripMenuItem.Text = "Edit PDF Info";
            modifyPDFInfoToolStripMenuItem.Click += modifyPDFInfoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(239, 6);
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(242, 32);
            categoriesToolStripMenuItem.Text = "Edit Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // editSubCatsToolStripMenuItem
            // 
            editSubCatsToolStripMenuItem.Name = "editSubCatsToolStripMenuItem";
            editSubCatsToolStripMenuItem.Size = new Size(242, 32);
            editSubCatsToolStripMenuItem.Text = "Edit Subcategories";
            editSubCatsToolStripMenuItem.Click += editSubCatsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(242, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1648, 1243);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(111, 33);
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
            menuStrip1.Size = new Size(1786, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPDFRecordsToolStripMenuItem, maintainCategoriesToolStripMenuItem, subCategoriesToolStripMenuItem, toolStripSeparator3, setupToolStripMenuItem });
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
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(223, 6);
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(226, 34);
            setupToolStripMenuItem.Text = "Setup";
            setupToolStripMenuItem.Click += setupToolStripMenuItem_Click;
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
            pdfImportButton.BackColor = Color.White;
            pdfImportButton.BackgroundImage = (Image)resources.GetObject("pdfImportButton.BackgroundImage");
            pdfImportButton.BackgroundImageLayout = ImageLayout.Center;
            pdfImportButton.FlatAppearance.BorderColor = Color.Gold;
            pdfImportButton.FlatAppearance.BorderSize = 6;
            pdfImportButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            pdfImportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            pdfImportButton.FlatStyle = FlatStyle.Popup;
            pdfImportButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pdfImportButton.ForeColor = Color.Firebrick;
            pdfImportButton.Location = new Point(762, 45);
            pdfImportButton.Name = "pdfImportButton";
            pdfImportButton.Size = new Size(281, 126);
            pdfImportButton.TabIndex = 4;
            pdfImportButton.Text = "Import NOW!";
            pdfImportButton.UseVisualStyleBackColor = false;
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
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(1492, 83);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(267, 33);
            categoryComboBox.TabIndex = 5;
            categoryComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1324, 91);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 6;
            label1.Text = "Show by Category:";
            // 
            // showAllButton
            // 
            showAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showAllButton.BackColor = SystemColors.ButtonHighlight;
            showAllButton.FlatStyle = FlatStyle.Popup;
            showAllButton.Location = new Point(1162, 133);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(111, 35);
            showAllButton.TabIndex = 7;
            showAllButton.Text = "Show All";
            showAllButton.UseVisualStyleBackColor = false;
            showAllButton.Click += showAllButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1370, 138);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 8;
            label2.Text = "Subcategory:";
            // 
            // subCatComboBox
            // 
            subCatComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subCatComboBox.FormattingEnabled = true;
            subCatComboBox.Location = new Point(1492, 135);
            subCatComboBox.Name = "subCatComboBox";
            subCatComboBox.Size = new Size(267, 33);
            subCatComboBox.TabIndex = 9;
            subCatComboBox.SelectedIndexChanged += subCatComboBox_SelectedIndexChanged;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            userNameTextBox.Location = new Point(151, 1241);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.ReadOnly = true;
            userNameTextBox.Size = new Size(225, 31);
            userNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 1244);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 11;
            label3.Text = "Repository for:";
            // 
            // selectorComboBox
            // 
            selectorComboBox.FormattingEnabled = true;
            selectorComboBox.Location = new Point(151, 76);
            selectorComboBox.Name = "selectorComboBox";
            selectorComboBox.Size = new Size(449, 33);
            selectorComboBox.TabIndex = 12;
            selectorComboBox.SelectedIndexChanged += selectorComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 80);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 13;
            label4.Text = "Select by Name:";
            label4.Click += label4_Click;
            // 
            // pdfCountTextBox
            // 
            pdfCountTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pdfCountTextBox.Location = new Point(918, 1241);
            pdfCountTextBox.Name = "pdfCountTextBox";
            pdfCountTextBox.ReadOnly = true;
            pdfCountTextBox.Size = new Size(63, 31);
            pdfCountTextBox.TabIndex = 15;
            pdfCountTextBox.Text = "10000";
            pdfCountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(782, 1243);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 16;
            label6.Text = "Pdfs Imported:";
            // 
            // gotToEndButton
            // 
            gotToEndButton.Location = new Point(451, 134);
            gotToEndButton.Name = "gotToEndButton";
            gotToEndButton.Size = new Size(149, 34);
            gotToEndButton.TabIndex = 17;
            gotToEndButton.Text = "Last Row";
            gotToEndButton.UseVisualStyleBackColor = true;
            gotToEndButton.Click += gotToEndButton_Click;
            // 
            // firstRowButton
            // 
            firstRowButton.Location = new Point(151, 134);
            firstRowButton.Name = "firstRowButton";
            firstRowButton.Size = new Size(149, 34);
            firstRowButton.TabIndex = 18;
            firstRowButton.Text = "First Row";
            firstRowButton.UseVisualStyleBackColor = true;
            firstRowButton.Click += firstRowButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(732, -3);
            label5.Name = "label5";
            label5.Size = new Size(342, 35);
            label5.TabIndex = 19;
            label5.Text = "Prototype - Local Use only!";
            // 
            // PDF_list
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1786, 1285);
            Controls.Add(label5);
            Controls.Add(firstRowButton);
            Controls.Add(gotToEndButton);
            Controls.Add(pdfCountTextBox);
            Controls.Add(label4);
            Controls.Add(label6);
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
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "PDF_list";
            Text = "My PDF LIst";
            Activated += PDF_list_Activated;
            Load += PDF_list_Load;
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
        private TextBox pdfCountTextBox;
        private Label label6;
        private Button gotToEndButton;
        private Button firstRowButton;
        private Label label5;
    }
}
