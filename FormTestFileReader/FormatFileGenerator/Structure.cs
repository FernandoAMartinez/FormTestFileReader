using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FormTestFileReader.FormatFileGenerator
{
    [Serializable]
    public class Structure
    {
        public Structure() { }

        [XmlElement]
        public string Id { get; set; }

        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public string Type { get; set; }

        public DataTable GridFormat { get; set; }

    }
}
