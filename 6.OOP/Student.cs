using System;

namespace OOP
{
   /// <summary>
   /// Derived class from Person that representts a student
   /// </summary>
   public class Student : Person
   {
      protected string major;

      public Student(string Name,string Surname, int Age,int Identifier,string Major) : base(Name, Surname, Age, Identifier)
      {
         this.major = Major;
      }

      /// <summary>
      /// Displaying students attributes
      /// </summary>
      public new void Display()
      {
         Console.WriteLine($"Major: {major}");
      }

      /// <summary>
      /// Displaying students careerpath
      /// </summary>
      public override void CareerPath()
      {
         Console.WriteLine("Learning for bachelor's degree");
      }
   }
}
