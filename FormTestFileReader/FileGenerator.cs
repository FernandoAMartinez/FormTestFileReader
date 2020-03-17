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

        #region Serialization
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

            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            LoadFormatsFromFile();
            //Fin Modificación - FernandoAMartinez - 17/03/2020

            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            BindingFromats = new BindingSource { DataSource = Formats };
            dgFormats.DataSource = BindingFromats;

            //Initialize DataGrids
            //dgFormats.Columns.Add("Id", "Id");
            //dgFormats.Columns.Add("Name", "Description");
            dgFormats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
            //dgStructures.Columns.Add("Id", "Id");
            //dgStructures.Columns.Add("Name", "Description");
            //dgStructures.Columns.Add("Type", "Type");
            dgStructures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Fin Modificación - FernandoAMartinez - 17/03/2020

            //DataColumn column = new DataColumn();
            //cbColumnType.DataSource = column.DataType.GetProperties();

            pbSaveFile.Minimum = 0;
            pbSaveFile.Maximum = 100;
            pbSaveFile.Step = 100;
            //serializationThread = new Thread(new ThreadStart(StartSerialization));

            
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
                //Inicio Modificación - FernandoAMartinez - 17/03/2020
                //Formats.Add(newFormat.Format);
                //dgFormats.Rows.Add(newFormat.Format.Id, newFormat.Format.Name);
                BindingFromats.Add(newFormat.Format);
                //Fin Modificación - FernandoAMartinez - 17/03/2020
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

            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            SelectedFormat = (FormatFileGenerator.Format)BindingFromats.Current;

            BindingStructures = new BindingSource { DataSource = SelectedFormat.Structures };
            dgStructures.DataSource = BindingStructures;
            

            //if (dgFormats.SelectedRows.Count == 1)
            //{
            //    SelectedFormat = Formats[dgFormats.SelectedRows[0].Index];
            //
            //    if (dgStructures.Rows != null)
            //        dgStructures.Rows.Clear();
            //
            //    if (SelectedFormat.Structures != null)
            //        foreach (FormatFileGenerator.Structure structure in SelectedFormat.Structures)
            //            dgStructures.Rows.Add(structure.Id, structure.Name, structure.Type);
            //}
            //
            ////Initialize the Grid
            //if (dgDataStructure.Columns.Count != 0 && dgDataStructure.Rows.Count != 0)
            //{
            //    dgDataStructure.Columns.Clear();
            //    dgDataStructure.Rows.Clear();
            //}
            //Fin Modificación - FernandoAMartinez - 17/03/2020
        }

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

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            DataColumn newColumn = new DataColumn();
            newColumn.ColumnName = tbColumnName.Text;
            //newColumn.MaxLength = Convert.ToInt32(tbMaxLength.Text);
            //newColumn.DataType = cbColumnType.SelectedIndex.GetType();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentConfiguration.Instance.SerializeFiles)
            {
                string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\";

                switch (CurrentConfiguration.Instance.SerializationType)
                {
                    case "XML":
                        filepath += "XMLFormats.xml";

                        using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(List<FormatFileGenerator.Format>));
                            serializer.Serialize(stream, Formats);
                            stream.Close();
                        }
                        break;

                    case "Binary":
                        filepath += "BinaryFormats.txt";

                        using(FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(stream, Formats);
                            stream.Close();
                        }
                        break;

                    case "SOAP":
                        filepath += "SOAPFormats.xml";

                        using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            
                        }
                        break;

                    default:
                        break;
                }
            }
            else MessageBox.Show("Please enable serialization on Preferences menu.", "Missing settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
        #endregion

        #region PreferencesManagement
        private void OpenPreferencesMenu()
        {
            PreferencesMenu preferences = new PreferencesMenu();
            preferences.ShowDialog();
            if (preferences.DialogResult == DialogResult.OK) { }
            else if (preferences.DialogResult == DialogResult.Cancel) { }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) => OpenPreferencesMenu();
        

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
        private void LoadFormatsFromFile()
        {
            //Inicio Modificación - FernandoAMartinez - 17/03/2020
            string filepath = CurrentConfiguration.Instance.FilesDirectory + @"\";

            switch (CurrentConfiguration.Instance.SerializationType)
            {
                case "XML":
                    filepath += "XMLFormats.xml";

                    try
                    {
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
                    }
                    catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); }
                    break;

                case "Binary":
                    filepath += "BinaryFormats.txt";

                    try
                    {
                        using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            if(Formats.Count == 0)
                            {
                                Formats = new List<FormatFileGenerator.Format>();
                                Formats = (List<FormatFileGenerator.Format>)formatter.Deserialize(stream);
                            }
                            stream.Close();
                        }
                    }
                    catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); }
                    break;

                case "SOAP":
                    filepath += "SOAPFormats.xml";

                    try
                    {
                        using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                        {

                        }
                    }
                    catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); }
                    break;

                default:
                    break;
            }


            //try
            //{
            //    using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            //    {
            //    }
            //
            //    if(Formats.Count != 0)
            //    {
            //        foreach (FormatFileGenerator.Format loadFormat in Formats)
            //        {
            //            dgFormats.Rows.Add(loadFormat.Id, loadFormat.Name);
            //
            //            if(loadFormat.Structures.Count != 0)
            //                foreach (FormatFileGenerator.Structure structure in loadFormat.Structures)
            //                    dgStructures.Rows.Add(structure.Id, structure.Name, structure.Type);
            //        }
            //    }
            //}
            //catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); }
            //Fin Modificación - FernandoAMartinez - 17/03/2020
        }
        #endregion
    }
}