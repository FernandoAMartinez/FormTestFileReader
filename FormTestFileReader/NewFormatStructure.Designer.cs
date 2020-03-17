namespace FormTestFileReader
{
    partial class NewFormatStructure
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
            this.rbFormat = new System.Windows.Forms.RadioButton();
            this.rbStructure = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbFormat
            // 
            this.rbFormat.AutoSize = true;
            this.rbFormat.Location = new System.Drawing.Point(12, 16);
            this.rbFormat.Name = "rbFormat";
            this.rbFormat.Size = new System.Drawing.Size(57, 17);
            this.rbFormat.TabIndex = 0;
            this.rbFormat.TabStop = true;
            this.rbFormat.Text = "Format";
            this.rbFormat.UseVisualStyleBackColor = true;
            this.rbFormat.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            // 
            // rbStructure
            // 
            this.rbStructure.AutoSize = true;
            this.rbStructure.Location = new System.Drawing.Point(12, 40);
            this.rbStructure.Name = "rbStructure";
            this.rbStructure.Size = new System.Drawing.Size(68, 17);
            this.rbStructure.TabIndex = 1;
            this.rbStructure.TabStop = true;
            this.rbStructure.Text = "Structure";
            this.rbStructure.UseVisualStyleBackColor = true;
            this.rbStructure.CheckedChanged += new System.EventHandler(this.rbStructure_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // tbGUID
            // 
            this.tbGUID.Enabled = false;
            this.tbGUID.Location = new System.Drawing.Point(137, 15);
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.Size = new System.Drawing.Size(200, 20);
            this.tbGUID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(137, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.Enabled = false;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(137, 91);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 21);
            this.cbType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(152, 65);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(185, 20);
            this.tbFileName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File Name";
            // 
            // NewFormatStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 150);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbGUID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbStructure);
            this.Controls.Add(this.rbFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewFormatStructure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add...";
            this.Load += new System.EventHandler(this.NewFormatStructure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFormat;
        private System.Windows.Forms.RadioButton rbStructure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGUID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label4;
    }
}