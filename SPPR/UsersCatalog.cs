using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AIS_DIBLOM
{
    class UsersCatalog
    {
        [XmlArray("UsersCatalog"), XmlArrayItem("User")]
        public List<User> Data { get; set; }
    }
}
