using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace FormTestFileReader
{
    public class BinaryStrategy : ISerializationStrategy
    {
        public void SerializeFile(string filepath, List<FormatFileGenerator.Format> formats)
        {
            filepath += "BinaryFormats.txt";

            using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, formats);
                stream.Close();
            }
        }

        public List<FormatFileGenerator.Format> DeserializeFile(string filepath)
        {
            filepath += "BinaryFormats.txt";
            List<FormatFileGenerator.Format> formats = new List<FormatFileGenerator.Format>();
            try
            {
                using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    if (formats.Count == 0)
                    {
                        formats = new List<FormatFileGenerator.Format>();
                        formats = (List<FormatFileGenerator.Format>)formatter.Deserialize(stream);
                    }
                    stream.Close();
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); formats = null; }

            return formats;
        }
    }
}
