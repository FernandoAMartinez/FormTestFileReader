using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestFileReader
{
    public partial class NewFormatStructure : Form
    {
        public FormatFileGenerator.Format Format { get; set; }

        public FormatFileGenerator.Structure Structure { get; set; }

        public Guid GUID { get; set; }

        public NewFormatStructure(string mode)
        {
            InitializeComponent();
            GUID = Guid.NewGuid();

            cbType.Items.Add("Header");
            cbType.Items.Add("Detail");
            cbType.Items.Add("Footer");

            if (mode == "F")
            {
                rbFormat.Checked = true;
                this.Text = "New Format";
            }
            else if (mode == "S")
            {
                rbStructure.Checked = true;
                this.Text = "New Structure";
            }
        }

        private void NewFormatStructure_Load(object sender, EventArgs e)
        {
            tbGUID.Text = GUID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbFormat.Checked)
            {
                Format = new FormatFileGenerator.Format()
                {
                    Id = tbGUID.Text,
                    Name = tbName.Text, 
                    FileName = tbFileName.Text
                };

                DialogResult = DialogResult.OK;
            }
            else
            {
                Structure = new FormatFileGenerator.Structure()
                {
                    Id = tbGUID.Text,
                    Name = tbName.Text,
                    Type = cbType.SelectedItem.ToString(),
                    GridFormat = new DataTable() { TableName = tbName.Text + "." + cbType.SelectedItem.ToString() }
                };

                DialogResult = DialogResult.OK;
            }
        }

        private void rbStructure_CheckedChanged(object sender, EventArgs e)
        {
            cbType.Enabled = true;
            tbFileName.Enabled = false;
        }

        private void rbFormat_CheckedChanged(object sender, EventArgs e)
        {
            cbType.Enabled = false;
            tbFileName.Enabled = true;
        }
    }
}
