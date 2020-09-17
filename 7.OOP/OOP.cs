using System;
using System.Collections.Generic;
using UserInputValidator;

namespace OOP
{
   /// <summary>
   /// Create a class representing a person. It should be characterized by:
   ///Name, Surname, Age and Identifier
   ///Derive the Person class in two other classes: Teacher and Student, each containing their own unique properties.
   ///Create a program that has 2 options for the user:
   ///To display a list of 4 teachers objects (when the user types “1” from keyboard)
   ///To display a list of 6 students objects(when the user types “2” from keyboard)
   ///Define any two different methods with the same name for each class.
   ///maybe a CareerPath method: a teacher can learn for his doctor’s degree, while a student must learn for his bachelor’s
   ///the output should be displayed in console
   /// </summary>
   class OOP
   {
      /// <summary>
      /// Method for reading in users option and validating it
      /// </summary>
      /// <param name="option"></param>
      public static void ChooseOption(ref int option)
      {
         do {

            Console.WriteLine("1. Display teacher names");
            Console.WriteLine("2. Display student names");
            Console.WriteLine("3. Exit");
            UserInputValidation.ValidateUserInput(ref option, "Choose an option");
            Console.WriteLine();

         } while (!(option == 1 || option == 2 || option == 3));
      }
      static void Main(string[] args)
      {
         List<Teacher> teachers = new List<Teacher>
         {
            new Teacher("Anne","Marie",30,83262,"Biology","DR"),
            new Teacher("Kate","Winslet",25,938274,"Mathematics","PHD"),
            new Teacher("Barbara", "Plavin", 26, 83737832, "Gymnastics", "DR"),
            new Teacher("Obama", "Barack", 55, 983262, "Politics", "DR")
          };

         List<Student> students = new List<Student>
         {
            new Student("Romee","Strjid",21,98362,"Informatics"),
            new Student("Viktor","Orban",25,938274,"Politics"),
            new Student("Ion", "Cruza", 26, 83737832, "Architecture"),
            new Student("Jennifer", "Aniston", 40, 1983262, "Drama"),
            new Student("Mariah", "Carry", 50, 1283262, "Drama"),
            new Student("Tomas", "Kent", 18, 247262, "Geography")
          };

         int option = 0;
            do {
            ChooseOption(ref option);
            switch (option) {
               case 1:
                  foreach (Teacher teacher in teachers) {
                     teacher.Display();
                     teacher.CareerPath();
                  }
                  break;
               case 2:
                  foreach (Student student in students) {
                     student.Display();
                     student.CareerPath();
                  }
                  break;
            }
            Console.WriteLine();
         } while (option != 3);
      }
   }
}