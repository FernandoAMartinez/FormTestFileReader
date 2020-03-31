using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTestFileReader
{
    public interface ISerializationStrategy
    {
        void SerializeFile(string filepath, List<FormatFileGenerator.Format> formats);
        List<FormatFileGenerator.Format> DeserializeFile(string filepath);
    }
}
