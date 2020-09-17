using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
  public class Person
   {
      private string name;
      private string surname;
      private int age;
      private int identifier;

      public Person(string name,string surname,int age,int identifier)
      {
         this.name = name;
         this.surname = surname;
         this.age = age;
         this.identifier = identifier;
      }

       public virtual void CareerPath()
      {
         Console.WriteLine("Learning for life");
      }

      /// <summary>
      /// Displaying attributes of person
      /// </summary>
      public void Display()
      {
         Console.Write($"Name: {name} Surname: {surname} Age: {Age} Identifier: {identifier} ");
      }
      public Person()
      {

      }
      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      public string Surname
      {
         get
         {
            return surname;
         }
         set
         {
           surname= value;
         }
      }

      public int Age
      {
         get
         {
            return age;
         }
         set
         {
            age = value;
         }
      }

      public int Identifier
      {
         get
         {
            return identifier;
         }
         set
         {
           identifier = value;
         }
      }
   }
}
