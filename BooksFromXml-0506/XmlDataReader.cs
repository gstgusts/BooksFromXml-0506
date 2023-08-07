using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksFromXml_0506
{
    public class XmlDataReader<T>
    {
        private string _rootName;
        public XmlDataReader(string? rootElementName = null) {
            _rootName = rootElementName;
        }
        public T Read(string path)
        {
            var serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(_rootName));
            using (var reader = new StreamReader(path))
            {
                var result = serializer.Deserialize(reader);

                if (result != null)
                {
                    return (T)result;
                }

                return default(T);
            }
        }
    }
}
