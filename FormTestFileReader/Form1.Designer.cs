namespace FormTestFileReader
{
    partial class Form1
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
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.lbSearchFile = new System.Windows.Forms.Label();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.txFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBankFile = new System.Windows.Forms.GroupBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dgvBankDetail = new System.Windows.Forms.DataGridView();
            this.gbTrailer = new System.Windows.Forms.GroupBox();
            this.dgvBankTrailer = new System.Windows.Forms.DataGridView();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.dgvBankHeader = new System.Windows.Forms.DataGridView();
            this.gbCreditCardFile = new System.Windows.Forms.GroupBox();
            this.gbCardHeader = new System.Windows.Forms.GroupBox();
            this.dgvCardHeader = new System.Windows.Forms.DataGridView();
            this.gbCardLot = new System.Windows.Forms.GroupBox();
            this.dgvCardLot = new System.Windows.Forms.DataGridView();
            this.gbCardTransactions = new System.Windows.Forms.GroupBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.gbParameters.SuspendLayout();
            this.gbBankFile.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDetail)).BeginInit();
            this.gbTrailer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTrailer)).BeginInit();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankHeader)).BeginInit();
            this.gbCreditCardFile.SuspendLayout();
            this.gbCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardHeader)).BeginInit();
            this.gbCardLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardLot)).BeginInit();
            this.gbCardTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Location = new System.Drawing.Point(24, 23);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(73, 21);
            this.rbBank.TabIndex = 0;
            this.rbBank.TabStop = true;
            this.rbBank.Text = "Bancos";
            this.rbBank.UseVisualStyleBackColor = true;
            this.rbBank.CheckedChanged += new System.EventHandler(this.tbBank_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(24, 51);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(78, 21);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Tarjetas";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.lbSearchFile);
            this.gbParameters.Controls.Add(this.btnProcessFile);
            this.gbParameters.Controls.Add(this.txFilePath);
            this.gbParameters.Controls.Add(this.label1);
            this.gbParameters.Controls.Add(this.rbBank);
            this.gbParameters.Controls.Add(this.rbCreditCard);
            this.gbParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbParameters.Location = new System.Drawing.Point(0, 0);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(1207, 87);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parametros de Selección";
            // 
            // lbSearchFile
            // 
            this.lbSearchFile.AutoSize = true;
            this.lbSearchFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearchFile.Location = new System.Drawing.Point(857, 53);
            this.lbSearchFile.Name = "lbSearchFile";
            this.lbSearchFile.Size = new System.Drawing.Size(22, 19);
            this.lbSearchFile.TabIndex = 5;
            this.lbSearchFile.Text = "...";
            this.lbSearchFile.Click += new System.EventHandler(this.lbSearchFile_Click);
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProcessFile.Location = new System.Drawing.Point(1113, 19);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(91, 65);
            this.btnProcessFile.TabIndex = 4;
            this.btnProcessFile.Text = "Procesar";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // txFilePath
            // 
            this.txFilePath.Location = new System.Drawing.Point(215, 50);
            this.txFilePath.Name = "txFilePath";
            this.txFilePath.Size = new System.Drawing.Size(636, 23);
            this.txFilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta";
            // 
            // gbBankFile
            // 
            this.gbBankFile.Controls.Add(this.gbDetail);
            this.gbBankFile.Controls.Add(this.gbTrailer);
            this.gbBankFile.Controls.Add(this.gbHeader);
            this.gbBankFile.Location = new System.Drawing.Point(16, 108);
            this.gbBankFile.Name = "gbBankFile";
            this.gbBankFile.Size = new System.Drawing.Size(588, 461);
            this.gbBankFile.TabIndex = 3;
            this.gbBankFile.TabStop = false;
            this.gbBankFile.Text = "Bancos";
            this.gbBankFile.Enter += new System.EventHandler(this.gbBankFile_Enter);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.dgvBankDetail);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetail.Location = new System.Drawing.Point(3, 90);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(582, 296);
            this.gbDetail.TabIndex = 5;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Registro de Detalle";
            // 
            // dgvBankDetail
            // 
            this.dgvBankDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankDetail.Location = new System.Drawing.Point(3, 19);
            this.dgvBankDetail.Name = "dgvBankDetail";
            this.dgvBankDetail.Size = new System.Drawing.Size(576, 274);
            this.dgvBankDetail.TabIndex = 1;
            // 
            // gbTrailer
            // 
            this.gbTrailer.Controls.Add(this.dgvBankTrailer);
            this.gbTrailer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbTrailer.Location = new System.Drawing.Point(3, 386);
            this.gbTrailer.Name = "gbTrailer";
            this.gbTrailer.Size = new System.Drawing.Size(582, 72);
            this.gbTrailer.TabIndex = 6;
            this.gbTrailer.TabStop = false;
            this.gbTrailer.Text = "Registro de Pie";
            // 
            // dgvBankTrailer
            // 
            this.dgvBankTrailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankTrailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankTrailer.Location = new System.Drawing.Point(3, 19);
            this.dgvBankTrailer.Name = "dgvBankTrailer";
            this.dgvBankTrailer.Size = new System.Drawing.Size(576, 50);
            this.dgvBankTrailer.TabIndex = 2;
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.dgvBankHeader);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Location = new System.Drawing.Point(3, 19);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(582, 71);
            this.gbHeader.TabIndex = 5;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Registro de Cabecera";
            // 
            // dgvBankHeader
            // 
            this.dgvBankHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankHeader.Location = new System.Drawing.Point(3, 19);
            this.dgvBankHeader.Name = "dgvBankHeader";
            this.dgvBankHeader.Size = new System.Drawing.Size(576, 49);
            this.dgvBankHeader.TabIndex = 0;
            // 
            // gbCreditCardFile
            // 
            this.gbCreditCardFile.Controls.Add(this.gbCardLot);
            this.gbCreditCardFile.Controls.Add(this.gbCardTransactions);
            this.gbCreditCardFile.Controls.Add(this.gbCardHeader);
            this.gbCreditCardFile.Location = new System.Drawing.Point(610, 108);
            this.gbCreditCardFile.Name = "gbCreditCardFile";
            this.gbCreditCardFile.Size = new System.Drawing.Size(537, 461);
            this.gbCreditCardFile.TabIndex = 4;
            this.gbCreditCardFile.TabStop = false;
            this.gbCreditCardFile.Text = "Tarjetas";
            // 
            // gbCardHeader
            // 
            this.gbCardHeader.Controls.Add(this.dgvCardHeader);
            this.gbCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCardHeader.Location = new System.Drawing.Point(3, 19);
            this.gbCardHeader.Name = "gbCardHeader";
            this.gbCardHeader.Size = new System.Drawing.Size(531, 71);
            this.gbCardHeader.TabIndex = 6;
            this.gbCardHeader.TabStop = false;
            this.gbCardHeader.Text = "Registro de Cabecera";
            // 
            // dgvCardHeader
            // 
            this.dgvCardHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCardHeader.Location = new System.Drawing.Point(3, 19);
            this.dgvCardHeader.Name = "dgvCardHeader";
            this.dgvCardHeader.Size = new System.Drawing.Size(525, 49);
            this.dgvCardHeader.TabIndex = 0;
            // 
            // gbCardLot
            // 
            this.gbCardLot.Controls.Add(this.dgvCardLot);
            this.gbCardLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCardLot.Location = new System.Drawing.Point(3, 90);
            this.gbCardLot.Name = "gbCardLot";
            this.gbCardLot.Size = new System.Drawing.Size(531, 71);
            this.gbCardLot.TabIndex = 7;
            this.gbCardLot.TabStop = false;
            this.gbCardLot.Text = "Registro de Detalle";
            // 
            // dgvCardLot
            // 
            this.dgvCardLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCardLot.Location = new System.Drawing.Point(3, 19);
            this.dgvCardLot.Name = "dgvCardLot";
            this.dgvCardLot.Size = new System.Drawing.Size(525, 49);
            this.dgvCardLot.TabIndex = 1;
            this.dgvCardLot.SelectionChanged += new System.EventHandler(this.dgvCardLot_SelectionChanged);
            // 
            // gbCardTransactions
            // 
            this.gbCardTransactions.Controls.Add(this.dgvTransactions);
            this.gbCardTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCardTransactions.Location = new System.Drawing.Point(3, 161);
            this.gbCardTransactions.Name = "gbCardTransactions";
            this.gbCardTransactions.Size = new System.Drawing.Size(531, 297);
            this.gbCardTransactions.TabIndex = 8;
            this.gbCardTransactions.TabStop = false;
            this.gbCardTransactions.Text = "Registro de Pie";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.Location = new System.Drawing.Point(3, 19);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(525, 275);
            this.dgvTransactions.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 578);
            this.Controls.Add(this.gbCreditCardFile);
            this.Controls.Add(this.gbBankFile);
            this.Controls.Add(this.gbParameters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Poceso de Cobros y Rechazos de Débito Automático";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbBankFile.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDetail)).EndInit();
            this.gbTrailer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTrailer)).EndInit();
            this.gbHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankHeader)).EndInit();
            this.gbCreditCardFile.ResumeLayout(false);
            this.gbCardHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardHeader)).EndInit();
            this.gbCardLot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardLot)).EndInit();
            this.gbCardTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBank;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lbSearchFile;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.TextBox txFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBankFile;
        private System.Windows.Forms.DataGridView dgvBankHeader;
        private System.Windows.Forms.GroupBox gbCreditCardFile;
        private System.Windows.Forms.DataGridView dgvBankTrailer;
        private System.Windows.Forms.DataGridView dgvBankDetail;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbTrailer;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.GroupBox gbCardHeader;
        private System.Windows.Forms.DataGridView dgvCardHeader;
        private System.Windows.Forms.GroupBox gbCardLot;
        private System.Windows.Forms.DataGridView dgvCardLot;
        private System.Windows.Forms.GroupBox gbCardTransactions;
        private System.Windows.Forms.DataGridView dgvTransactions;
    }
}

