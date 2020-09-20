using System;

namespace OOP
{
   /// <summary>
   /// Class that represents a person
   /// </summary>
   public abstract class Person
   {
      public string name { get; set; }
      public string surname { get; set; }
      public int age { get; set; }
      public int identifier { get; set; }

      public Person(string name,string surname,int age,int identifier)
      {
         this.name = name;
         this.surname = surname;
         this.age = age;
         this.identifier = identifier;
      }

      public Person() { }

      /// <summary>
      /// Showing the career path of the person
      /// </summary>
       public virtual void CareerPath()
      {
         Console.WriteLine("Learning for life");
      }

      /// <summary>
      /// Displaying attributes of person
      /// </summary>
      public virtual void GetDetail()
      {
         Console.Write($"Name: {name} Surname: {surname} Age: {age} Identifier: {identifier} ");
      }

     
   }
}
