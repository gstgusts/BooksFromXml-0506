using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksFromXml_0506.Models
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlArray("TeamMembers")]
        public Book[] Books { get; set; }
    }
}
