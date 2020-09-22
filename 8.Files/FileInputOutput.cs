using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files
{
   /// <summary>
   /// Class for writing and reading from files
   /// </summary>
   public class FileInputOutput
   {

      /// <summary>
      /// Method for finding a file and copying its content to another file whilst converting every character to uppercase
      /// </summary>
      public static void ConvertFileToUppercase()
      {
         string oldFile = string.Empty;
         UserInputValidator.UserInputValidation.ValidateUserInput(ref oldFile, "Type the files name");
         //C:\\Users\\Szilvia\\Desktop\\Trimble2020\\TrimbleWorkshop\\Resources\\convertLowerToUppercase.txt
         oldFile = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+"\\Resources", oldFile);
         if (System.IO.File.Exists(oldFile)) {
            Console.WriteLine("File exists");
            string newFile = string.Empty;
            UserInputValidator.UserInputValidation.ValidateUserInput(ref newFile, "Type the new files name");
            newFile =Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", newFile);
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
         } else {
            Console.WriteLine("File DOES NOT exists");
         }
      }
   }
}
