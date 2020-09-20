using OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Files
{
   /// <summary>
   ///1. Build a method that accepts a list of professors or students and serializes that list as XML locally.(xml file creation)
   ///The file should be overwritten if it already exists when the method is called.
   ///2. Build another method that deserializes the xml file and binds the result to a List type variable(s) : students, teachers(read from xml students and teachers)
   ///3. Create a program that prompts the user for the name of a text file.the program will check that the file exists, displaying a message and quitting if it does not.
   ///the file will be opened and copied to another file (prompt the user for the file name), but with every character converted to uppercase.
   ///4.Create a program that fills in a document with the results of a sports team by your choice(football/basketball/ handball etc.) and print the following statistics : 
   ///number of Wins/Draws/Losses Goals/Points Scored;goals/Points Conceded number of points(count with 3p for W, 1p for D, 0p for L)

   /// </summary>
   class File
   {
      /// <summary>
      /// generic method for serializing an object to xml filee
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="anyobject"></param>
      /// <param name="xmlFilePath"></param>
      public static void SerializeToXml<T>(T anyobject, string xmlFilePath)
      {
         XmlSerializer xmlSerializer = new XmlSerializer(anyobject.GetType());

         using (StreamWriter writer = new StreamWriter(xmlFilePath)) {
            xmlSerializer.Serialize(writer, anyobject);
            writer.Close();
         }

      }

    /// <summary>
    /// method for finding a file and copying its content to another file whilst convertin every character to uppercase
    /// </summary>
      public static void FindFile()
      {
         string oldFile = string.Empty;
         UserInputValidator.UserInputValidation.ValidateUserInput(ref oldFile, "Type the location of the file");
         //C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lowercase.txt
         if (System.IO.File.Exists(oldFile)) {
            Console.WriteLine("File exists");
            string newFile = string.Empty;
            UserInputValidator.UserInputValidation.ValidateUserInput(ref newFile, "Type the files name");
            newFile = @"C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\" + newFile + ".txt";
            StreamReader fileRw = System.IO.File.OpenText(oldFile);
            StreamWriter fileWr = System.IO.File.CreateText(newFile);
            string line;
            do {
               line = fileRw.ReadLine();
               if (line != null)
                  fileWr.WriteLine(line.ToUpper());
            }
            while (line != null);
            fileRw.Close();
            fileWr.Close();
         }
      }
     

      static void Main(string[] args)
      {
         List<Teacher> teachers = new List<Teacher> {
            new Teacher(){name="Anne",surname="Marie",age=30,identifier=83262,workingHours=5,subject="Biology"},
            new Teacher(){name="Kate",surname="Winslet",age=25,identifier=938274,workingHours=8,subject="Mathematics" }
          };

         List<Student> students = new List<Student> {
            new Student(){ name = "Anna", surname = "Bela",age= 45,identifier= 38373,yearOfStudy=1,studyProgram= "oodhf" },
            new Student() { name="Viktor",surname= "Orban",age= 25,identifier= 938274,yearOfStudy= 3,studyProgram= "Politics" },
            new Student(){name="Ion", surname="Cruza",age= 26, identifier=83737832,yearOfStudy=4,studyProgram= "Architecture" },
            new Student(){name="Jennifer",surname= "Aniston",age =40, identifier=1983262,yearOfStudy=6,studyProgram= "Drama" }
          };

        
         //1.
         SerializeToXml(students, "C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists.xml");
         XmlSerializer serializer1 = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("ArrayOfStudent"));
         StreamReader stReader = new StreamReader("C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists.xml");
         //2.
         List<Student>st = (List<Student>)serializer1.Deserialize(stReader);
         stReader.Close();
         SerializeToXml(teachers, "C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists.xml");
         XmlSerializer serializer2 = new XmlSerializer(typeof(List<Teacher>), new XmlRootAttribute("ArrayOfTeacher"));
         StreamReader strReader = new StreamReader("C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists.xml");
         List<Teacher> t = (List<Teacher>)serializer2.Deserialize(strReader);

         //1.
         JsonSerializer serializer3 = new JsonSerializer();
         using StreamWriter sw = new StreamWriter(@"C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists2.json");
         using JsonWriter writer = new JsonTextWriter(sw);
         serializer3.Serialize(writer, students);
         sw.Close();
         writer.Close();

         //2.
        // StreamReader streamReader = new StreamReader("C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists2.json");
        // List<Student> sss=JsonConvert.DeserializeObject<List<Student>>("C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\lists2.json");

         //3.
         FindFile();
      }
   }
}