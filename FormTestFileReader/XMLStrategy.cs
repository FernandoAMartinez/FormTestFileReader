using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace FormTestFileReader
{
   public class XMLStrategy : ISerializationStrategy
    {
        public void SerializeFile(string filepath, List<FormatFileGenerator.Format> formats)
        {
            filepath += "XMLFormats.xml";

            using (FileStream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<FormatFileGenerator.Format>));
                serializer.Serialize(stream, formats);
                stream.Close();
            }
        }

        public List<FormatFileGenerator.Format> DeserializeFile(string filepath)
        {
            filepath += "XMLFormats.xml";
            List<FormatFileGenerator.Format> formats = new List<FormatFileGenerator.Format>();
            try
            {
                using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<FormatFileGenerator.Format>));
                    if (formats.Count == 0)
                    {
                        formats = new List<FormatFileGenerator.Format>();
                        formats = (List<FormatFileGenerator.Format>)serializer.Deserialize(stream);
                    }

                    stream.Close();
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show("Previous settings not found " + ex.Message, "Settings not found"); formats = null; }

            return formats;
        }
    }
}
