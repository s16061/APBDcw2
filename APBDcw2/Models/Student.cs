using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBDcw2.Models
{
    [XmlRoot(ElementName = "student")]
    public class Student
    {
        [XmlAttribute(attributeName:"indexNumber")]
        public string indexNumber { get; set; }

        [XmlElement(elementName: "fname")]
        public string fname { get; set; }

        [XmlElement(elementName: "lname")]
        public string lname { get; set; }

        [XmlElement(elementName: "birthdate")]
        public string birthdate { get; set; }

        [XmlElement(elementName: "email")]
        public string email { get; set; }

        [XmlElement(elementName: "mothersName")]
        public string mothersName { get; set; }

        [XmlElement(elementName: "fathersName")]
        public string fathersName { get; set; }
 
        [XmlElement(elementName: "studies")]
        public Study Studies = new Study();
    }
}
