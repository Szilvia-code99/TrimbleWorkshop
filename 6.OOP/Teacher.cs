using System;

namespace OOP
{
   /// <summary>
   /// Derived class from Person that represents a teacher
   /// </summary>
   public class Teacher : Person
   {
      public int workingHours { get; set; }
      public string subject { get; set; }
      
      public Teacher(string Name, string Surname, int Age, int Identifier, int workingHours, string subject): base(Name, Surname, Age, Identifier)
      {
         this.workingHours = workingHours;
         this.subject = subject;
      }

      public Teacher() { }
      /// <summary>
      /// Displaying teachers attributes
      /// </summary>
      public new void GetDetail()
      {
         Console.WriteLine($"Working hours: {workingHours} Subject: {subject}");
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
