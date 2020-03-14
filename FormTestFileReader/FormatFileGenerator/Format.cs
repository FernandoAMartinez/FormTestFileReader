using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace FormTestFileReader.FormatFileGenerator
{
    //[Serializable]
    //public class FormatPack
    //{
    //    [XmlArray("Formats")]
    //    public List<Format> PackOfFormats { get; set; }
    //}

    [Serializable]
    public class Format
    {
        public Format(){}

        [XmlElement]
        public string Id { get; set; }

        [XmlElement]
        public string Name { get; set; }

        [XmlAttribute]
        public string FileName { get; set; }

        [XmlElement]
        public List<Structure> Structures { get; set; }
    }
}
