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

namespace FormTestFileReader
{
    public partial class FileGenerator : Form
    {
        public Thread serializationThread { get; set; }

        public List<FormatFileGenerator.Format> Formats { get; set; }

        //Current Format Selected
        public FormatFileGenerator.Format SelectedFormat { get; set; }

        //Current Structure Selected
        public FormatFileGenerator.Structure SelectedStructure { get; set; }

        public FileGenerator()
        {
            InitializeComponent();

            CurrentConfiguration.Instance.CurrentUser = Environment.UserName;

            

            //Initialize List of Formats
            Formats = new List<FormatFileGenerator.Format>();

            //Initialize DataGrids
            dgFormats.Columns.Add("Id", "Id");
            dgFormats.Columns.Add("Name", "Description");
            dgFormats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgStructures.Columns.Add("Id", "Id");
            dgStructures.Columns.Add("Name", "Description");
            dgStructures.Columns.Add("Type", "Type");
            dgStructures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DataColumn column = new DataColumn();
            //cbColumnType.DataSource = column.DataType.GetProperties();

            pbSaveFile.Minimum = 0;
            pbSaveFile.Maximum = 100;
            pbSaveFile.Step = 100;
            //serializationThread = new Thread(new ThreadStart(StartSerialization));

            //Load Preferences & Formats
            LoadPreferencesFromFile();

            LoadFormatsFromFile();
        }

        private void FileGenerator_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
            //Start Serialization
            //StreamReader reader;
            //
            //try
            //{
            //    reader = new StreamReader(@"C:\Users\fernando.b.martinez\Documents\SerializableFormatos.xml");
            //    if(reader != null)
            //    {
            //        StartDeserialization(reader);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //serializationThread.Abort();
            //}
            //finally
            //{
            //    serializationThread.Start();
            //}            

            //if(Formats != null)
            //    dgFormats.DataSource = Formats;
        }

        private void dgFormats_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(e.KeyChar == 13)
            {
                var index = dgFormats.CurrentCell.RowIndex;
                FormatFileGenerator.Format newFormat = new FormatFileGenerator.Format();
                newFormat.Id = dgFormats.Rows[index].Cells[0].Value.ToString();
                newFormat.Name = dgFormats.Rows[index].Cells[1].Value.ToString();
                //newFormat.Structures = new List<FormatFileGenerator.Structure>();
                Formats.Add(newFormat);

                foreach (DataGridViewCell cell in dgFormats.Rows[index].Cells)
                    cell.ReadOnly = true;

                dgFormats.EditMode = DataGridViewEditMode.EditOnEnter;
                dgFormats.ReadOnly = true;
            }
            */
            //TODO: 
        }

        //TODO
        //KEEPS SERIALIZING THE FILE
        private void StartSerialization()
        {
            while (serializationThread.IsAlive)
            {
                //using (StreamWriter writer = new StreamWriter(@"C:\Users\fernando.b.martinez\Documents\SerializableFormatos.xml"))
                using (FileStream stream = new FileStream(@"C:\Users\fernando.b.martinez\Documents\SerializableFormatos.txt", FileMode.Create, FileAccess.Write))
                {
                    if (Formats.Count > 0)
                    {
                        //XmlSerializer serializer = new XmlSerializer(typeof(FormatFileGenerator.FormatPack));
                        //serializer.Serialize(writer, Formats);
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, Formats);
                        stream.Close();
                    }
                }
            }
        }

        //TODO
        //STARTS THE SERIALIZATION FOR THE FORMATS TO BACKUP ON A XML FILE
        private void StartDeserialization(StreamReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FormatFileGenerator.Format));
            try
            {
                Formats = (List<FormatFileGenerator.Format>)serializer.Deserialize(reader);

            }
            catch (Exception)
            {
                Formats = new List<FormatFileGenerator.Format>();
            }
            finally
            {
                reader.Close();
            }
        }

        //CREATES A NEW FORMAT
        private void newFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFormatStructure newFormat = new NewFormatStructure("F");
            if(newFormat.ShowDialog() == DialogResult.OK)
            {
                Formats.Add(newFormat.Format);
                dgFormats.Rows.Add(newFormat.Format.Id, newFormat.Format.Name);
            }
        }

        //CLOSES THE APPLICATION
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoadFormatsFromFile();
        }

        //SELECTS THE CURRENT FORMAT OF THE APPLICATION
        private void dgFormats_SelectionChanged(object sender, EventArgs e)
        {

            if (dgFormats.SelectedRows.Count == 1)
            {
                SelectedFormat = Formats[dgFormats.SelectedRows[0].Index];

                if (dgStructures.Rows != null)
                    dgStructures.Rows.Clear();

                if (SelectedFormat.Structures != null)
                    foreach (FormatFileGenerator.Structure structure in SelectedFormat.Structures)
                        dgStructures.Rows.Add(structure.Id, structure.Name, structure.Type);
            }

            //Initialize the Grid
            if (dgDataStructure.Columns.Count != 0 && dgDataStructure.Rows.Count != 0)
            {
                dgDataStructure.Columns.Clear();
                dgDataStructure.Rows.Clear();
            }
        }

        //CREATE A NEW STRUCTURE FOR THE SELECTED FORMAT
        private void openFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFormatStructure newStructure = new NewFormatStructure("S");
            if (newStructure.ShowDialog() == DialogResult.OK)
            {
                if (SelectedFormat.Structures == null)
                    SelectedFormat.Structures = new List<FormatFileGenerator.Structure>();

                SelectedFormat.Structures.Add(newStructure.Structure);
                
                dgStructures.Rows.Add(newStructure.Structure.Id, newStructure.Structure.Name, newStructure.Structure.Type);
            }
        }

        private void dgStructures_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedFormat != null)
            {
                if (dgStructures.SelectedRows.Count == 1)
                {
                    panelContainer.Visible = true;

                    SelectedStructure = SelectedFormat.Structures[dgStructures.SelectedRows[0].Index];

                    if (SelectedStructure.GridFormat == null)
                        SelectedStructure.GridFormat = new DataTable();

                    dgDataStructure.DataSource = SelectedStructure.GridFormat;

                    if (SelectedStructure.GridFormat.TableName == null)
                        SelectedStructure.GridFormat.TableName = SelectedFormat.Name + SelectedStructure.Name;

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

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            DataColumn newColumn = new DataColumn();
            newColumn.ColumnName = tbColumnName.Text;
            //newColumn.MaxLength = Convert.ToInt32(tbMaxLength.Text);
            //newColumn.DataType = cbColumnType.SelectedIndex.GetType();

            SelectedStructure.GridFormat.Columns.Add(newColumn);
            lbColumns.Text = SelectedStructure.GridFormat.Columns.Count.ToString();
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedStructure.GridFormat.Rows.Add();
            lbRows.Text = SelectedStructure.GridFormat.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\" + "Formats_Test.xml";
            using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<FormatFileGenerator.Format>));
                serializer.Serialize(stream, Formats);
                stream.Close();
            }
        }

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

            MessageBox.Show(builder.ToString());

            await ProcessFileAsync(builder);
        }

        //WRITE THE FILE
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

        #region PreferencesManagement
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesMenu preferences = new PreferencesMenu();
            preferences.ShowDialog();
            if(preferences.DialogResult == DialogResult.OK)
            {

            }
            else if (preferences.DialogResult == DialogResult.Cancel)
            {

            }
        }

        private void LoadPreferencesFromFile()
        {
            using (FileStream stream = new FileStream(@"C:\Users\fernando.b.martinez\Desktop\CurrentConfiguration.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CurrentConfiguration));
                CurrentConfiguration.Instance.LoadPreferences((CurrentConfiguration)serializer.Deserialize(stream));
                stream.Close();
            }
        }
        #endregion

        #region FormatPreferences
        private void LoadFormatsFromFile()
        {
            string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\" + "Formats_Test.xml";
            using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<FormatFileGenerator.Format>));
                if (Formats.Count == 0)
                {
                    Formats = new List<FormatFileGenerator.Format>();
                    Formats = (List<FormatFileGenerator.Format>)serializer.Deserialize(stream);
                }

                stream.Close();
            }

            if(Formats.Count != 0)
            {
                foreach (FormatFileGenerator.Format loadFormat in Formats)
                {
                    dgFormats.Rows.Add(loadFormat.Id, loadFormat.Name);

                    if(loadFormat.Structures.Count != 0)
                    {
                        foreach (FormatFileGenerator.Structure structure in loadFormat.Structures)
                        {
                            dgStructures.Rows.Add(structure.Id, structure.Name, structure.Type);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
