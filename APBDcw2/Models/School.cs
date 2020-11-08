using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBDcw2.Models
{
    [XmlRoot(ElementName = "uczelnia")]
    public class School
    {
        public School()
        {
            createdAt = DateTime.Now.ToString("dd.mm.yyyy");
        }



        [XmlAttribute(attributeName: "createdAt")]
        public string createdAt { get; set; }

        [XmlAttribute(attributeName: "author")]
        public string author { get; set; }

        [XmlArray(elementName: "studenci")]
        public List<Student> students = new List<Student>();

        public void AddStudents(Student student)
        {
            students.Add(student);
        }
        
    }

}
