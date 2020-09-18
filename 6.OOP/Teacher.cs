using System;

namespace OOP
{
   /// <summary>
   /// Derived class from Person that represents a teacher
   /// </summary>
   public class Teacher : Person
   {
      protected string department;
      protected string title;
      
      public Teacher(string Name, string Surname, int Age, int Identifier, string department, string title): base(Name, Surname, Age, Identifier)
      {
         this.department = department;
         this.title = title;
      }

      /// <summary>
      /// Displaying teachers attributes
      /// </summary>
      public new void Display()
      {
         Console.WriteLine($"Departament: {department} Title: {title}");
      }
      /// <summary>
      /// Displaying teachers careerpath
      /// </summary>
      public new void CareerPath()
      {
         Console.WriteLine("Learning for doctor's degree");
      }
   }
}
