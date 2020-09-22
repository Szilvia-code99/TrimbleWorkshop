using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
   public class FacultyManager : IFacultyManager
   {
      protected List<Student> students;
      protected List<Teacher> teachers;

      public FacultyManager(List<Student> students, List<Teacher> teachers)
      {
         this.students = students;
         this.teachers = teachers;
      }

      /// <summary>
      /// Method for making announcements
      /// </summary>
      public void MakeAnnouncement()
      {
         Console.WriteLine("This is the faculty manager. I want to announce that...");
      }

      /// <summary>
      /// Method for returning list of students
      /// </summary>
      /// <returns></returns>
      public List<Student> GetStudents()
      {
         return students;
      }

      /// <summary>
      /// Method for returning list of teachers 
      /// </summary>
      /// <returns></returns>
      public List<Teacher> GetTeachers()
      {
         return teachers;
      }
   }
}
