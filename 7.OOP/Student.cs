using System;

namespace OOP
{
   class Student:Person
   {
      private string major;

      public Student(string Name,string Surname, int Age,int Identifier,string Major) : base(Name, Surname, Age, Identifier)
      {
         this.major = Major;
      }

      /// <summary>
      /// Displaying students attributes
      /// </summary>
      public new void Display()
      {
         base.Display();
         Console.WriteLine($"Major: {major}");
      }

      /// <summary>
      /// Displaying students careerpath
      /// </summary>
      public override void CareerPath()
      {
         Console.WriteLine("Learning for bachelor's degree");
      }
      public string Major
      {
         get
         {
            return major;
         }
         set
         {
            major = value;
         }
      }
   }
}
