using APBDcw2.Models;
using System;
using System.IO;
using System.Xml.Serialization;

namespace APBDcw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data\\dane.csv";
            string resultpath = @"Data\\result.xml";
            string format = "xml";

            try
            {
                path = args[0];
            }
            catch
            {
                path = @"Data\\dane.csv";
            }

            try
            {
                resultpath = args[1];
            }
            catch
            {
                resultpath = @"Data\\result.xml";
            }

            try
            {
                format = args[2];
            }
            catch
            {
                format = "xml";
            }

            LoadData(path, resultpath, format);

                
            }

        private static void LoadData(string path, string resultpath, string format)
        {
            var fi = new FileInfo(path);
            var school = new School();
            
            using (var stream = new StreamReader(fi.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] list = line.Split(',');

                    var st = new Student
                    {
                        fname = list[0],
                        lname = list[1],

                        indexNumber = 's' + list[4],
                        birthdate = list[5],
                        email = list[6],
                        mothersName = list[7],
                        fathersName = list[8],

                        Studies = new Study
                        {
                            name = list[2],
                            mode = list[3]
                        }

                    };
                    school.AddStudents(st);

                }
            }

            SaveData(resultpath, school, format);
        }

        private static void SaveData(string resultpath, School school, string format)
        {
            if (format == "xml")
            {
                FileStream writer = new FileStream(resultpath, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(School));
                serializer.Serialize(writer, school);
            }
            if (format == "json")
            {

            }

        }

    }
    }

