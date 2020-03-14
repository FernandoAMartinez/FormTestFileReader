namespace FormTestFileReader
{
    partial class FileGenerator
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.structurePanel = new System.Windows.Forms.Panel();
            this.dgStructures = new System.Windows.Forms.DataGridView();
            this.fieldFormats = new System.Windows.Forms.Panel();
            this.dgFormats = new System.Windows.Forms.DataGridView();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.fileDataPanel = new System.Windows.Forms.Panel();
            this.gbFormatStructure = new System.Windows.Forms.GroupBox();
            this.dgDataStructure = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel = new System.Windows.Forms.Panel();
            this.gridViewCustomPanel = new System.Windows.Forms.Panel();
            this.gbDataGridLoad = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.tbMaxLength = new System.Windows.Forms.TextBox();
            this.cbColumnType = new System.Windows.Forms.ComboBox();
            this.tbColumnName = new System.Windows.Forms.TextBox();
            this.fileResumePanel = new System.Windows.Forms.Panel();
            this.gbFileResume = new System.Windows.Forms.GroupBox();
            this.lbColumns = new System.Windows.Forms.Label();
            this.lbRows = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControlMenu = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSaveFile = new System.Windows.Forms.ProgressBar();
            this.panelMenu.SuspendLayout();
            this.structurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStructures)).BeginInit();
            this.fieldFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFormats)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.fileDataPanel.SuspendLayout();
            this.gbFormatStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataStructure)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.gridViewCustomPanel.SuspendLayout();
            this.gbDataGridLoad.SuspendLayout();
            this.fileResumePanel.SuspendLayout();
            this.gbFileResume.SuspendLayout();
            this.panelControlMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.structurePanel);
            this.panelMenu.Controls.Add(this.fieldFormats);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(315, 628);
            this.panelMenu.TabIndex = 0;
            // 
            // structurePanel
            // 
            this.structurePanel.Controls.Add(this.dgStructures);
            this.structurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structurePanel.Location = new System.Drawing.Point(0, 286);
            this.structurePanel.Name = "structurePanel";
            this.structurePanel.Size = new System.Drawing.Size(315, 342);
            this.structurePanel.TabIndex = 0;
            // 
            // dgStructures
            // 
            this.dgStructures.AllowUserToAddRows = false;
            this.dgStructures.AllowUserToDeleteRows = false;
            this.dgStructures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStructures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStructures.Location = new System.Drawing.Point(0, 0);
            this.dgStructures.Name = "dgStructures";
            this.dgStructures.ReadOnly = true;
            this.dgStructures.Size = new System.Drawing.Size(315, 342);
            this.dgStructures.TabIndex = 1;
            this.dgStructures.SelectionChanged += new System.EventHandler(this.dgStructures_SelectionChanged);
            // 
            // fieldFormats
            // 
            this.fieldFormats.Controls.Add(this.dgFormats);
            this.fieldFormats.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldFormats.Location = new System.Drawing.Point(0, 0);
            this.fieldFormats.Name = "fieldFormats";
            this.fieldFormats.Size = new System.Drawing.Size(315, 286);
            this.fieldFormats.TabIndex = 0;
            // 
            // dgFormats
            // 
            this.dgFormats.AllowUserToAddRows = false;
            this.dgFormats.AllowUserToDeleteRows = false;
            this.dgFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFormats.Location = new System.Drawing.Point(0, 0);
            this.dgFormats.Name = "dgFormats";
            this.dgFormats.ReadOnly = true;
            this.dgFormats.Size = new System.Drawing.Size(315, 286);
            this.dgFormats.TabIndex = 1;
            this.dgFormats.SelectionChanged += new System.EventHandler(this.dgFormats_SelectionChanged);
            this.dgFormats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgFormats_KeyPress);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.fileDataPanel);
            this.panelContainer.Controls.Add(this.topPanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(315, 39);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1092, 628);
            this.panelContainer.TabIndex = 1;
            // 
            // fileDataPanel
            // 
            this.fileDataPanel.Controls.Add(this.gbFormatStructure);
            this.fileDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDataPanel.Location = new System.Drawing.Point(0, 163);
            this.fileDataPanel.Name = "fileDataPanel";
            this.fileDataPanel.Size = new System.Drawing.Size(1092, 465);
            this.fileDataPanel.TabIndex = 1;
            // 
            // gbFormatStructure
            // 
            this.gbFormatStructure.Controls.Add(this.dgDataStructure);
            this.gbFormatStructure.Controls.Add(this.menuStrip1);
            this.gbFormatStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFormatStructure.Location = new System.Drawing.Point(0, 0);
            this.gbFormatStructure.Name = "gbFormatStructure";
            this.gbFormatStructure.Size = new System.Drawing.Size(1092, 465);
            this.gbFormatStructure.TabIndex = 0;
            this.gbFormatStructure.TabStop = false;
            this.gbFormatStructure.Text = "Data Structure";
            // 
            // dgDataStructure
            // 
            this.dgDataStructure.AllowUserToAddRows = false;
            this.dgDataStructure.AllowUserToDeleteRows = false;
            this.dgDataStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDataStructure.Location = new System.Drawing.Point(3, 43);
            this.dgDataStructure.Name = "dgDataStructure";
            this.dgDataStructure.Size = new System.Drawing.Size(1086, 419);
            this.dgDataStructure.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addRowToolStripMenuItem.Text = "Add Row";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.gridViewCustomPanel);
            this.topPanel.Controls.Add(this.fileResumePanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1092, 163);
            this.topPanel.TabIndex = 1;
            // 
            // gridViewCustomPanel
            // 
            this.gridViewCustomPanel.Controls.Add(this.gbDataGridLoad);
            this.gridViewCustomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewCustomPanel.Location = new System.Drawing.Point(0, 0);
            this.gridViewCustomPanel.Name = "gridViewCustomPanel";
            this.gridViewCustomPanel.Size = new System.Drawing.Size(724, 163);
            this.gridViewCustomPanel.TabIndex = 0;
            // 
            // gbDataGridLoad
            // 
            this.gbDataGridLoad.Controls.Add(this.label5);
            this.gbDataGridLoad.Controls.Add(this.label3);
            this.gbDataGridLoad.Controls.Add(this.label4);
            this.gbDataGridLoad.Controls.Add(this.btnAddColumn);
            this.gbDataGridLoad.Controls.Add(this.tbMaxLength);
            this.gbDataGridLoad.Controls.Add(this.cbColumnType);
            this.gbDataGridLoad.Controls.Add(this.tbColumnName);
            this.gbDataGridLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDataGridLoad.Location = new System.Drawing.Point(0, 0);
            this.gbDataGridLoad.Name = "gbDataGridLoad";
            this.gbDataGridLoad.Size = new System.Drawing.Size(724, 163);
            this.gbDataGridLoad.TabIndex = 0;
            this.gbDataGridLoad.TabStop = false;
            this.gbDataGridLoad.Text = "Format Customizer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Column Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column Name";
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(402, 117);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(227, 29);
            this.btnAddColumn.TabIndex = 1;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // tbMaxLength
            // 
            this.tbMaxLength.Location = new System.Drawing.Point(143, 58);
            this.tbMaxLength.Name = "tbMaxLength";
            this.tbMaxLength.Size = new System.Drawing.Size(110, 23);
            this.tbMaxLength.TabIndex = 2;
            // 
            // cbColumnType
            // 
            this.cbColumnType.FormattingEnabled = true;
            this.cbColumnType.Location = new System.Drawing.Point(454, 26);
            this.cbColumnType.Name = "cbColumnType";
            this.cbColumnType.Size = new System.Drawing.Size(175, 24);
            this.cbColumnType.TabIndex = 1;
            // 
            // tbColumnName
            // 
            this.tbColumnName.Location = new System.Drawing.Point(143, 26);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Size = new System.Drawing.Size(183, 23);
            this.tbColumnName.TabIndex = 0;
            // 
            // fileResumePanel
            // 
            this.fileResumePanel.Controls.Add(this.gbFileResume);
            this.fileResumePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fileResumePanel.Location = new System.Drawing.Point(724, 0);
            this.fileResumePanel.Name = "fileResumePanel";
            this.fileResumePanel.Size = new System.Drawing.Size(368, 163);
            this.fileResumePanel.TabIndex = 1;
            // 
            // gbFileResume
            // 
            this.gbFileResume.Controls.Add(this.lbColumns);
            this.gbFileResume.Controls.Add(this.lbRows);
            this.gbFileResume.Controls.Add(this.label2);
            this.gbFileResume.Controls.Add(this.label1);
            this.gbFileResume.Controls.Add(this.button1);
            this.gbFileResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileResume.Location = new System.Drawing.Point(0, 0);
            this.gbFileResume.Name = "gbFileResume";
            this.gbFileResume.Size = new System.Drawing.Size(368, 163);
            this.gbFileResume.TabIndex = 0;
            this.gbFileResume.TabStop = false;
            this.gbFileResume.Text = "File Resume";
            // 
            // lbColumns
            // 
            this.lbColumns.AutoSize = true;
            this.lbColumns.Location = new System.Drawing.Point(95, 62);
            this.lbColumns.Name = "lbColumns";
            this.lbColumns.Size = new System.Drawing.Size(62, 17);
            this.lbColumns.TabIndex = 4;
            this.lbColumns.Text = "Columns";
            // 
            // lbRows
            // 
            this.lbRows.AutoSize = true;
            this.lbRows.Location = new System.Drawing.Point(95, 30);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(42, 17);
            this.lbRows.TabIndex = 3;
            this.lbRows.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add To File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControlMenu
            // 
            this.panelControlMenu.Controls.Add(this.mainMenu);
            this.panelControlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMenu.Location = new System.Drawing.Point(0, 0);
            this.panelControlMenu.Name = "panelControlMenu";
            this.panelControlMenu.Size = new System.Drawing.Size(1407, 39);
            this.panelControlMenu.TabIndex = 2;
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1407, 39);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormatToolStripMenuItem,
            this.openFormatToolStripMenuItem,
            this.exportToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 35);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFormatToolStripMenuItem
            // 
            this.newFormatToolStripMenuItem.Name = "newFormatToolStripMenuItem";
            this.newFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.newFormatToolStripMenuItem.Text = "New Format";
            this.newFormatToolStripMenuItem.Click += new System.EventHandler(this.newFormatToolStripMenuItem_Click);
            // 
            // openFormatToolStripMenuItem
            // 
            this.openFormatToolStripMenuItem.Name = "openFormatToolStripMenuItem";
            this.openFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openFormatToolStripMenuItem.Text = "New Structure";
            this.openFormatToolStripMenuItem.Click += new System.EventHandler(this.openFormatToolStripMenuItem_Click);
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exportToFileToolStripMenuItem.Text = "Export to file...";
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(70, 35);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(54, 35);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pbSaveFile
            // 
            this.pbSaveFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbSaveFile.Location = new System.Drawing.Point(0, 667);
            this.pbSaveFile.Name = "pbSaveFile";
            this.pbSaveFile.Size = new System.Drawing.Size(1407, 14);
            this.pbSaveFile.TabIndex = 3;
            // 
            // FileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 681);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelControlMenu);
            this.Controls.Add(this.pbSaveFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FileGenerator";
            this.Text = "Plain Text File Generator ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FileGenerator_Load);
            this.panelMenu.ResumeLayout(false);
            this.structurePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStructures)).EndInit();
            this.fieldFormats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFormats)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.fileDataPanel.ResumeLayout(false);
            this.gbFormatStructure.ResumeLayout(false);
            this.gbFormatStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataStructure)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.gridViewCustomPanel.ResumeLayout(false);
            this.gbDataGridLoad.ResumeLayout(false);
            this.gbDataGridLoad.PerformLayout();
            this.fileResumePanel.ResumeLayout(false);
            this.gbFileResume.ResumeLayout(false);
            this.gbFileResume.PerformLayout();
            this.panelControlMenu.ResumeLayout(false);
            this.panelControlMenu.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelControlMenu;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Panel structurePanel;
        private System.Windows.Forms.Panel fieldFormats;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgStructures;
        private System.Windows.Forms.DataGridView dgFormats;
        private System.Windows.Forms.Panel fileDataPanel;
        private System.Windows.Forms.Panel gridViewCustomPanel;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.GroupBox gbDataGridLoad;
        private System.Windows.Forms.Panel fileResumePanel;
        private System.Windows.Forms.GroupBox gbFileResume;
        private System.Windows.Forms.GroupBox gbFormatStructure;
        private System.Windows.Forms.DataGridView dgDataStructure;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.TextBox tbMaxLength;
        private System.Windows.Forms.ComboBox cbColumnType;
        private System.Windows.Forms.TextBox tbColumnName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbColumns;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbSaveFile;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}