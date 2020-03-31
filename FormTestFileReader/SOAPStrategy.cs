using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections.Generic;

namespace FormTestFileReader
{
    public class SOAPStrategy : ISerializationStrategy
    {
        public void SerializeFile(string filepath, List<FormatFileGenerator.Format> formats)
        {
            filepath += "SOAPFormats.xml";
            using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(stream, formats);
                stream.Close();
            }
        }

        public List<FormatFileGenerator.Format> DeserializeFile(string filepath)
        {
            filepath += "SOAPFormats.xml";
            List<FormatFileGenerator.Format> formats = new List<FormatFileGenerator.Format>();
            try
            {
                using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {
                    SoapFormatter formatter = new SoapFormatter();
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
