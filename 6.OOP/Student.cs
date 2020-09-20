using System;

namespace OOP
{
   /// <summary>
   /// Derived class from Person that representts a student
   /// </summary>
   public class Student : Person
   {
      public int yearOfStudy { get; set; }
      public string studyProgram {get; set; }

      public Student() { }
      public Student(string name,string surname, int age,int identifier,int yearOfStudy,string studyProgram) : base(name, surname, age, identifier)
      {
         this.studyProgram = studyProgram;
         this.yearOfStudy = yearOfStudy;
      }

      /// <summary>
      /// Displaying students attributes
      /// </summary>
      public new void GetDetail()
      {
         Console.WriteLine($"Year of study: {yearOfStudy} Study program: {studyProgram}");
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
