using System;

namespace OOP
{
   public class Teacher : Person
   {
      private string department;
      private string title;
      
      public Teacher(string Name,string Surname,int Age,int Identifier,string department,string title): base(Name,Surname,Age,Identifier)
      {
         this.department = department;
         this.title = title;
      }

      /// <summary>
      /// Displaying teachers attributes
      /// </summary>
      public new void Display()
      {
         base.Display();
         Console.WriteLine($"Departament: {department} Title: {title}");
      }
      /// <summary>
      /// Displaying teachers careerpath
      /// </summary>
      public new void CareerPath()
      {
         Console.WriteLine("Learning for doctor's degree");
      }
      public string Department
      {
         get
         {
            return department;
         }
         set
         {
            department = value;
         }
      }

      public string Title
      {
         get
         {
            return title;
         }
         set
         {
            title = value;
         }
      }
   }
}
