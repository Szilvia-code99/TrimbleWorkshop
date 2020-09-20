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
     
      static void Main(string[] args)
      {
         List<Teacher> teachers = new List<Teacher> {
            new Teacher("Anne","Marie",30,83262,5,"Biology"),
            new Teacher("Kate","Winslet",25,938274,8,"Mathematics"),
            new Teacher("Barbara", "Plavin", 26, 83737832,10, "Gymnastics"),
            new Teacher("Obama", "Barack", 55, 983262, 2,"Politics")
          };

         List<Student> students = new List<Student> {
            new Student("Romee","Strjid",21,98362,2,"Informatics"),
            new Student("Viktor","Orban",25,938274,3,"Politics"),
            new Student("Ion", "Cruza", 26, 83737832,4, "Architecture"),
            new Student("Jennifer", "Aniston", 40, 1983262,6, "Drama"),
            new Student("Mariah", "Carry", 50, 1283262,3, "Drama"),
            new Student("Tomas", "Kent", 18, 247262, 4,"Geography")
          };

         int option = 0;
            do {
            UserOptionSelection.ChooseOption(ref option);
            switch (option) {
               case 1:
                  foreach (Teacher teacher in teachers) {
                    teacher.GetDetail();
                     ((Person)teacher).CareerPath();
                  }
                  break;
               case 2:
                  foreach (Student student in students) {
                     student.GetDetail();
                     student.CareerPath();
                  }
                  break;
            }
            Console.WriteLine();
         } while (option != 3);
      }
   }
}