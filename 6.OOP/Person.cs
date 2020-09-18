using System;

namespace OOP
{
   /// <summary>
   /// Class that represents a person
   /// </summary>
   public abstract class Person
   {
      protected string name;
      protected string surname;
      protected int age;
      protected int identifier;

      public Person(string name,string surname,int age,int identifier)
      {
         this.name = name;
         this.surname = surname;
         this.age = age;
         this.identifier = identifier;
      }

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
      public virtual void Display()
      {
         Console.Write($"Name: {name} Surname: {surname} Age: {age} Identifier: {identifier} ");
      }
   }
}
