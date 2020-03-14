using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

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
    public partial class PreferencesMenu : Form
    {
        public PreferencesMenu()
        {
            InitializeComponent();

            TreeNode nodeSerialization = new TreeNode();
            nodeSerialization.Name = "nodeSerialization";
            nodeSerialization.Text = "Serialization";
            TreeNode[] firstNode = new TreeNode[] { nodeSerialization };

            TreeNode mainNode = new TreeNode("Preferences" ,firstNode);
            mainNode.Name = "mainNode";
            this.preferencesTree.Nodes.Add(mainNode);
            mainNode.Expand();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
        

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            CurrentConfiguration.Instance.FilesDirectory = tbSelectedPath.Text;

            if (cbEnableSerialization.Checked)
            {
                CurrentConfiguration.Instance.SerializeFiles = true;
                if (rbBinary.Checked) CurrentConfiguration.Instance.SerializationType = "Binary";
                else if (rbSOAP.Checked) CurrentConfiguration.Instance.SerializationType = "SOAP";
                else if (rbXML.Checked) CurrentConfiguration.Instance.SerializationType = "XML";
            }
            else
            {
                CurrentConfiguration.Instance.SerializeFiles = false;
            }

            SaveChangesOnFile();
        }

        private void btnSelecthPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            string filepath = "";

            if (browserDialog.ShowDialog() == DialogResult.OK)
                filepath = browserDialog.SelectedPath.ToString();

            tbSelectedPath.Text = filepath;
        }

        private void cbEnableSerialization_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableSerialization.Checked) gbSerializationSettings.Enabled = true;
            else gbSerializationSettings.Enabled = false;
        }

        private void PreferencesMenu_Load(object sender, EventArgs e)
        {

        }

        private void preferencesTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = preferencesTree.SelectedNode;

            switch (node.Text)
            {
                case "Serialization":
                    contentPanel.Controls.Clear();
                    contentPanel.Controls.Add(gbSerialization);
                    gbSerialization.Dock = DockStyle.Fill;
                    gbSerialization.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void contentPanel_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void gbSerialization_VisibleChanged(object sender, EventArgs e)
        {
            if (gbSerialization.Visible)
            {
                if (CurrentConfiguration.Instance.SerializeFiles)
                {
                    cbEnableSerialization.Checked = true;

                    tbSelectedPath.Text = CurrentConfiguration.Instance.FilesDirectory;

                    if (CurrentConfiguration.Instance.SerializationType == "Binary") rbBinary.Checked = true;
                    else if (CurrentConfiguration.Instance.SerializationType == "SOAP") rbSOAP.Checked = true;
                    else if (CurrentConfiguration.Instance.SerializationType == "XML") rbXML.Checked = true;
                }
                else
                {
                    cbEnableSerialization.Checked = false;
                    gbSerializationSettings.Enabled = false;
                }
            }
        }


        #region SerializeConfiguration
        public void SaveChangesOnFile()
        {
            using (FileStream stream = new FileStream(CurrentConfiguration.Instance.FilesDirectory + @"\" + "CurrentConfiguration.xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CurrentConfiguration));
                serializer.Serialize(stream, CurrentConfiguration.Instance);
                stream.Close();
            }
        }
        #endregion
    }
}
