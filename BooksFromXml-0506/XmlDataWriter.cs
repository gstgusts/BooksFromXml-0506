using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksFromXml_0506
{
    public class XmlDataWriter<T>
    {
        private string _rootName;
        public XmlDataWriter(string? rootElementName = null) {
            _rootName = rootElementName;
        }
        public void Write(string path, T data)
        {
            var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(_rootName));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
                                                                                                                                                                                                                                                            