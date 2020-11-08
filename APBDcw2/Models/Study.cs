using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBDcw2.Models
{
    public class Study
    {
        [XmlElement(elementName: "name")]
        public string name { get; set; }

        [XmlElement(elementName: "mode")]
        public string mode { get; set; }
    }
}
