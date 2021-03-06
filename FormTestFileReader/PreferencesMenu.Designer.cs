﻿namespace FormTestFileReader
{
    partial class PreferencesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesMenu));
            this.treeMenu = new System.Windows.Forms.Panel();
            this.preferencesTree = new System.Windows.Forms.TreeView();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.gbSerialization = new System.Windows.Forms.GroupBox();
            this.gbSerializationSettings = new System.Windows.Forms.GroupBox();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbSOAP = new System.Windows.Forms.RadioButton();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecthPath = new System.Windows.Forms.Button();
            this.tbSelectedPath = new System.Windows.Forms.TextBox();
            this.panelCheckSerial = new System.Windows.Forms.Panel();
            this.cbEnableSerialization = new System.Windows.Forms.CheckBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbStandardSettings = new System.Windows.Forms.GroupBox();
            this.cbBackground = new System.Windows.Forms.CheckBox();
            this.treeMenu.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.gbSerialization.SuspendLayout();
            this.gbSerializationSettings.SuspendLayout();
            this.panelCheckSerial.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Controls.Add(this.preferencesTree);
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeMenu.Location = new System.Drawing.Point(0, 0);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(242, 549);
            this.treeMenu.TabIndex = 0;
            // 
            // preferencesTree
            // 
            this.preferencesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferencesTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesTree.Location = new System.Drawing.Point(0, 0);
            this.preferencesTree.Name = "preferencesTree";
            this.preferencesTree.Size = new System.Drawing.Size(242, 549);
            this.preferencesTree.TabIndex = 0;
            this.preferencesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.preferencesTree_AfterSelect);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Controls.Add(this.gbStandardSettings);
            this.contentPanel.Controls.Add(this.gbSerialization);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(242, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(509, 549);
            this.contentPanel.TabIndex = 1;
            this.contentPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.contentPanel_ControlAdded);
            // 
            // gbSerialization
            // 
            this.gbSerialization.Controls.Add(this.gbSerializationSettings);
            this.gbSerialization.Controls.Add(this.panelCheckSerial);
            this.gbSerialization.Location = new System.Drawing.Point(8, 15);
            this.gbSerialization.Name = "gbSerialization";
            this.gbSerialization.Size = new System.Drawing.Size(491, 270);
            this.gbSerialization.TabIndex = 3;
            this.gbSerialization.TabStop = false;
            this.gbSerialization.Text = "Serialization Settings";
            this.gbSerialization.Visible = false;
            this.gbSerialization.VisibleChanged += new System.EventHandler(this.gbSerialization_VisibleChanged);
            // 
            // gbSerializationSettings
            // 
            this.gbSerializationSettings.Controls.Add(this.cbBackground);
            this.gbSerializationSettings.Controls.Add(this.rbXML);
            this.gbSerializationSettings.Controls.Add(this.rbSOAP);
            this.gbSerializationSettings.Controls.Add(this.rbBinary);
            this.gbSerializationSettings.Controls.Add(this.label1);
            this.gbSerializationSettings.Controls.Add(this.label2);
            this.gbSerializationSettings.Controls.Add(this.btnSelecthPath);
            this.gbSerializationSettings.Controls.Add(this.tbSelectedPath);
            this.gbSerializationSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSerializationSettings.Location = new System.Drawing.Point(3, 67);
            this.gbSerializationSettings.Name = "gbSerializationSettings";
            this.gbSerializationSettings.Size = new System.Drawing.Size(485, 200);
            this.gbSerializationSettings.TabIndex = 5;
            this.gbSerializationSettings.TabStop = false;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(152, 145);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(54, 21);
            this.rbXML.TabIndex = 6;
            this.rbXML.TabStop = true;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // rbSOAP
            // 
            this.rbSOAP.AutoSize = true;
            this.rbSOAP.Location = new System.Drawing.Point(150, 118);
            this.rbSOAP.Name = "rbSOAP";
            this.rbSOAP.Size = new System.Drawing.Size(64, 21);
            this.rbSOAP.TabIndex = 5;
            this.rbSOAP.TabStop = true;
            this.rbSOAP.Text = "SOAP";
            this.rbSOAP.UseVisualStyleBackColor = true;
            // 
            // rbBinary
            // 
            this.rbBinary.AutoSize = true;
            this.rbBinary.Location = new System.Drawing.Point(150, 91);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(66, 21);
            this.rbBinary.TabIndex = 4;
            this.rbBinary.TabStop = true;
            this.rbBinary.Text = "Binary";
            this.rbBinary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serialization Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serialization Type";
            // 
            // btnSelecthPath
            // 
            this.btnSelecthPath.Location = new System.Drawing.Point(432, 41);
            this.btnSelecthPath.Name = "btnSelecthPath";
            this.btnSelecthPath.Size = new System.Drawing.Size(43, 24);
            this.btnSelecthPath.TabIndex = 3;
            this.btnSelecthPath.Text = "...";
            this.btnSelecthPath.UseVisualStyleBackColor = true;
            this.btnSelecthPath.Click += new System.EventHandler(this.btnSelecthPath_Click);
            // 
            // tbSelectedPath
            // 
            this.tbSelectedPath.Enabled = false;
            this.tbSelectedPath.Location = new System.Drawing.Point(18, 42);
            this.tbSelectedPath.Name = "tbSelectedPath";
            this.tbSelectedPath.Size = new System.Drawing.Size(408, 23);
            this.tbSelectedPath.TabIndex = 2;
            // 
            // panelCheckSerial
            // 
            this.panelCheckSerial.Controls.Add(this.cbEnableSerialization);
            this.panelCheckSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCheckSerial.Location = new System.Drawing.Point(3, 19);
            this.panelCheckSerial.Name = "panelCheckSerial";
            this.panelCheckSerial.Size = new System.Drawing.Size(485, 48);
            this.panelCheckSerial.TabIndex = 4;
            // 
            // cbEnableSerialization
            // 
            this.cbEnableSerialization.AutoSize = true;
            this.cbEnableSerialization.Location = new System.Drawing.Point(17, 14);
            this.cbEnableSerialization.Name = "cbEnableSerialization";
            this.cbEnableSerialization.Size = new System.Drawing.Size(152, 21);
            this.cbEnableSerialization.TabIndex = 4;
            this.cbEnableSerialization.Text = "Enable Serialization";
            this.cbEnableSerialization.UseVisualStyleBackColor = true;
            this.cbEnableSerialization.CheckedChanged += new System.EventHandler(this.cbEnableSerialization_CheckedChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.buttonsPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 549);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(751, 43);
            this.bottomPanel.TabIndex = 2;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btnCancel);
            this.buttonsPanel.Controls.Add(this.btnSaveChanges);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(453, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(298, 43);
            this.buttonsPanel.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(9, 8);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(136, 29);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // gbStandardSettings
            // 
            this.gbStandardSettings.Location = new System.Drawing.Point(11, 291);
            this.gbStandardSettings.Name = "gbStandardSettings";
            this.gbStandardSettings.Size = new System.Drawing.Size(488, 252);
            this.gbStandardSettings.TabIndex = 4;
            this.gbStandardSettings.TabStop = false;
            this.gbStandardSettings.Text = "Standard Settings";
            this.gbStandardSettings.Visible = false;
            // 
            // cbBackground
            // 
            this.cbBackground.AutoSize = true;
            this.cbBackground.Location = new System.Drawing.Point(291, 92);
            this.cbBackground.Name = "cbBackground";
            this.cbBackground.Size = new System.Drawing.Size(184, 21);
            this.cbBackground.TabIndex = 7;
            this.cbBackground.Text = "Background Serialization";
            this.cbBackground.UseVisualStyleBackColor = true;
            // 
            // PreferencesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 592);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.bottomPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesMenu";
            this.Text = "PreferencesMenu";
            this.Load += new System.EventHandler(this.PreferencesMenu_Load);
            this.treeMenu.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.gbSerialization.ResumeLayout(false);
            this.gbSerializationSettings.ResumeLayout(false);
            this.gbSerializationSettings.PerformLayout();
            this.panelCheckSerial.ResumeLayout(false);
            this.panelCheckSerial.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel treeMenu;
        private System.Windows.Forms.TreeView preferencesTree;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox gbSerialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecthPath;
        private System.Windows.Forms.TextBox tbSelectedPath;
        private System.Windows.Forms.GroupBox gbSerializationSettings;
        private System.Windows.Forms.CheckBox cbEnableSerialization;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbSOAP;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.Panel panelCheckSerial;
        private System.Windows.Forms.GroupBox gbStandardSettings;
        private System.Windows.Forms.CheckBox cbBackground;
    }
}