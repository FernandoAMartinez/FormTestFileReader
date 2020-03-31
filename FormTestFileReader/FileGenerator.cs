using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;


namespace FormTestFileReader
{
    public partial class FileGenerator : Form
    {

        #region Threads
        public Thread serializationThread { get; set; }
        #endregion

        #region Collections
        public List<FormatFileGenerator.Format> Formats { get; set; }
        #endregion

        #region BindingSources
        public BindingSource BindingFromats { get; set; }

        public BindingSource BindingStructures { get; set; }
        #endregion

        #region Objects
        //Current Format Selected
        public FormatFileGenerator.Format SelectedFormat { get; set; }

        //Current Structure Selected
        public FormatFileGenerator.Structure SelectedStructure { get; set; }
        #endregion

        public FileGenerator()
        {
            InitializeComponent();

            CurrentConfiguration.Instance.CurrentUser = Environment.UserName;

            //Initialize List of Formats
            Formats = new List<FormatFileGenerator.Format>();

            //Load Preferences & Formats
            LoadPreferencesFromFile();
            LoadFormatsFromFile();

            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            BindingFromats = new BindingSource { DataSource = Formats };
            dgFormats.DataSource = BindingFromats;
            //Fin Modificación - FernandoAMartinez - 17/03/2020

            dgFormats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStructures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pbSaveFile.Minimum = 0;
            pbSaveFile.Maximum = 100;
            pbSaveFile.Step = 100;

            serializationThread = new Thread(new ThreadStart(StartSerialization));
        }
        private void FileGenerator_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;

            if (CurrentConfiguration.Instance.SerializeFiles && CurrentConfiguration.Instance.BackgroundSerialization)
                if(!serializationThread.IsAlive)
                    serializationThread.Start();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializationThread.Abort();
            this.Close();
        }

        #region Formats
        //CREATES A NEW FORMAT
        private void newFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFormatStructure newFormat = new NewFormatStructure("F");
            if(newFormat.ShowDialog() == DialogResult.OK)
            {
                //Inicio Modificación - FernandoAMartinez - 17/03/2020
                //Formats.Add(newFormat.Format);
                //dgFormats.Rows.Add(newFormat.Format.Id, newFormat.Format.Name);
                BindingFromats.Add(newFormat.Format);
                //Fin Modificación - FernandoAMartinez - 17/03/2020
            }
        }

        //SELECTS THE CURRENT FORMAT OF THE APPLICATION
        private void dgFormats_SelectionChanged(object sender, EventArgs e)
        {
            SelectedFormat = (FormatFileGenerator.Format)BindingFromats.Current;

            BindingStructures = new BindingSource { DataSource = SelectedFormat.Structures };
            dgStructures.DataSource = BindingStructures;
        }
        #endregion

        #region Structures
        //CREATE A NEW STRUCTURE FOR THE SELECTED FORMAT
        private void openFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFormatStructure newStructure = new NewFormatStructure("S");
            if (newStructure.ShowDialog() == DialogResult.OK)
            {
                if (SelectedFormat.Structures == null)
                    SelectedFormat.Structures = new List<FormatFileGenerator.Structure>();

                //Inicio Modificación - FernandoAMartinez - 17/03/2020
                BindingStructures.Add(newStructure.Structure);
                //SelectedFormat.Structures = (List<FormatFileGenerator.Structure>)BindingStructures.List;
                SelectedFormat.Structures.Add(newStructure.Structure);
                //dgStructures.Rows.Add(newStructure.Structure.Id, newStructure.Structure.Name, newStructure.Structure.Type);
                //Fin Modificación - FernandoAMartinez - 17/03/2020
            }
        }

        //SELECTION OF THE CURRENT STRUCTURE OF THE FORMAT
        private void dgStructures_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedFormat != null)
            {
                if (dgStructures.SelectedRows.Count == 1)
                {
                    panelContainer.Visible = true;

                    //Inicio Modificación - FernandoAMartinez - 17/03/2020
                    //SelectedStructure = SelectedFormat.Structures[dgStructures.SelectedRows[0].Index];
                    SelectedStructure = (FormatFileGenerator.Structure)BindingStructures.Current;
                    //Fin Modificación - FernandoAMartinez - 17/03/2020

                    if (SelectedStructure.GridFormat == null)
                        SelectedStructure.GridFormat = new DataTable();

                    dgDataStructure.DataSource = SelectedStructure.GridFormat;

                    if (SelectedStructure.GridFormat.TableName == null)
                        SelectedStructure.GridFormat.TableName = string.Format("{0}-{1}",SelectedFormat.Name,SelectedStructure.Name);

                    lbRows.Text = SelectedStructure.GridFormat.Rows.Count.ToString();
                    lbColumns.Text = SelectedStructure.GridFormat.Columns.Count.ToString();
                }
                else
                {
                    panelContainer.Visible = false;
                }
            }
            else MessageBox.Show("Please select a Format from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region DataTableManupulation
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            DataColumn newColumn = new DataColumn();
            newColumn.ColumnName = tbColumnName.Text;

            SelectedStructure.GridFormat.Columns.Add(newColumn);
            lbColumns.Text = SelectedStructure.GridFormat.Columns.Count.ToString();

            tbColumnName.Clear();
            tbColumnName.Focus();
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedStructure.GridFormat.Rows.Add();
            lbRows.Text = SelectedStructure.GridFormat.Rows.Count.ToString();
        }
        #endregion

        #region Serialization
        private void StartSerialization() 
        {
            while (serializationThread.IsAlive)
                SerializeFormats();
        }
        private void SerializeFormats()
        {
            if (CurrentConfiguration.Instance.SerializeFiles)
            {
                string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\";
                CurrentConfiguration.Instance.ExecuteSerialization(filepath, Formats);
            }
            else MessageBox.Show("Please enable serialization on Preferences menu.", "Missing settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DeserializeFormats()
        {
            if (CurrentConfiguration.Instance.SerializeFiles)
            {
                string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\";

                switch (CurrentConfiguration.Instance.SerializationType)
                {
                    case "XML":
                        CurrentConfiguration.Instance.SetStrategy(new XMLStrategy());
                        break;
                
                    case "Binary":
                        CurrentConfiguration.Instance.SetStrategy(new BinaryStrategy());
                        break;
                
                    case "SOAP":
                        CurrentConfiguration.Instance.SetStrategy(new SOAPStrategy());
                        break;
                }
                Formats = CurrentConfiguration.Instance.ExecuteDeserialization(filepath);
            }
        }
        #endregion

        #region ExportToFile
        private async void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbSaveFile.Refresh();

            StringBuilder builder = new StringBuilder();

            foreach (FormatFileGenerator.Structure structure in SelectedFormat.Structures)
            {
                foreach (DataRow row in structure.GridFormat.Rows)
                {
                    var columnConcat = string.Join("", row.ItemArray);
                    builder.Append(columnConcat + "\n");
                }
            }
            
            await ProcessFileAsync(builder);
        }
        public async Task ProcessFileAsync(StringBuilder builder)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            string filepath = "";

            if (browserDialog.ShowDialog() == DialogResult.OK)
                filepath = browserDialog.SelectedPath.ToString();

            string filename = SelectedFormat.FileName.ToString();

            await WriteFileFormatAsync(filepath, filename, builder.ToString());
        }   
        public async Task WriteFileFormatAsync(string filepath, string filename, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filepath + @"\" + filename,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
                pbSaveFile.PerformStep();
            };
        }
        #endregion

        #region PreferencesManagement
        private void OpenPreferencesMenu()
        {
            PreferencesMenu preferences = new PreferencesMenu();
            preferences.ShowDialog();
            if (preferences.DialogResult == DialogResult.OK)
            {
                //Inicio Modificación - FernandoAMartinez - 17/03/2020
                switch (CurrentConfiguration.Instance.BackgroundSerialization)
                {
                    case true:
                        if (serializationThread != null)
                            if (!serializationThread.IsAlive)
                            {
                                serializationThread = new Thread(new ThreadStart(StartSerialization));
                                serializationThread.Start();
                            }
                        break;

                    case false:
                        if(serializationThread != null)
                            if(serializationThread.IsAlive)
                                serializationThread.Abort();
                        break;
                }
                //Fin Modificación - FernandoAMartinez - 17/03/2020
            }
            else if (preferences.DialogResult == DialogResult.Cancel) { }
        }
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) => 
            OpenPreferencesMenu();
        private void LoadPreferencesFromFile()
        {
            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            string filepath = Application.StartupPath + @"\";

            try
            {
                using (FileStream stream = new FileStream(filepath + "CurrentConfiguration.xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(CurrentConfiguration));
                    CurrentConfiguration.Instance.LoadPreferences((CurrentConfiguration)serializer.Deserialize(stream));
                    stream.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Previous settings not found. \nPlease configure initial settings. \n" + ex.Message, "Settings not found");
                OpenPreferencesMenu();
            }
            //Fin Modificación - FernandoAMartinez - 17/03/2020
        }
        #endregion

        #region FormatPreferences
        private void LoadFormatsFromFile() => 
            DeserializeFormats();
        private void saveFormatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CurrentConfiguration.Instance.BackgroundSerialization) SerializeFormats();
            else MessageBox.Show("Background serialization is running...\nChanges are being saved automatically.", "Background saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}