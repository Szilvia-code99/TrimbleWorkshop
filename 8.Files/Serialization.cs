using Newtonsoft.Json;
using OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Files
{
   /// <summary>
   /// Class for managing file serialization/deserialization into/from xml,json file
   /// </summary>
   class Serialization
   {
      List<Student> students;
      List<Teacher> teachers;

      public Serialization()
      {
          teachers = new List<Teacher> {
            new Teacher(){name="Anne",surname="Marie",age=30,identifier=83262,workingHours=5,subject="Biology"},
            new Teacher(){name="Kate",surname="Winslet",age=25,identifier=938274,workingHours=8,subject="Mathematics" }
          };

          students = new List<Student> {
            new Student(){ name = "Anna", surname = "Bela",age= 45,identifier= 38373,yearOfStudy=1,studyProgram= "oodhf" },
            new Student() { name="Viktor",surname= "Orban",age= 25,identifier= 938274,yearOfStudy= 3,studyProgram= "Politics" },
            new Student(){name="Ion", surname="Cruza",age= 26, identifier=83737832,yearOfStudy=4,studyProgram= "Architecture" },
            new Student(){name="Jennifer",surname= "Aniston",age =40, identifier=1983262,yearOfStudy=6,studyProgram= "Drama" }
          };

      }
      /// <summary>
      /// generic method for serializing an object to xml filee
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="anyobject"></param>
      /// <param name="xmlFilePath"></param>
      public  void SerializeToXml<T>(T anyobject, string xmlFilePath)
      {
         XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());

         using (StreamWriter writer = new StreamWriter(xmlFilePath)) {
            xmlSerializer.Serialize(writer, anyobject);
            writer.Close();
         }
      }

      public void SerializeListOfTeachersToXml()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "lists.xml");
         SerializeToXml(teachers, path);
      }

      public void DeserializeListOfTeachersFromXml()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "lists.xml");
         XmlSerializer serializer = new XmlSerializer(typeof(List<Teacher>), new XmlRootAttribute("ArrayOfTeacher"));
         StreamReader strReader = new StreamReader(path);
         List<Teacher> t = (List<Teacher>)serializer.Deserialize(strReader);
         strReader.Close();
      }

      public void SerializeListOfStudentsToXml()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "lists.xml");
         SerializeToXml(students, path);
      }

      public void DeserializeListOfStudentsFromXml()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "lists.xml");
         XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("ArrayOfStudent"));
         StreamReader strReader = new StreamReader(path);
         List<Student> t = (List<Student>)serializer.Deserialize(strReader);
         strReader.Close();
      }

      public void SerializeListOfStudentsToJson()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "lists2.json");
         Newtonsoft.Json.JsonSerializer serializer3 = new Newtonsoft.Json.JsonSerializer();
            using StreamWriter sw = new StreamWriter(@path);
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer3.Serialize(writer, students);
            sw.Close();
            writer.Close();
      }

      public void SerializeListOfTeachersToJson()
      {
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "list2s.json");
         Newtonsoft.Json.JsonSerializer serializer3 = new Newtonsoft.Json.JsonSerializer();
         using StreamWriter sw = new StreamWriter(@path);
         using JsonWriter writer = new JsonTextWriter(sw);
         serializer3.Serialize(writer, teachers);
         sw.Close();
         writer.Close();
      }

   }
}
