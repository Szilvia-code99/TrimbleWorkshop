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
      public void MakeAnnouncement()
      {
         Console.WriteLine("This is the faculty manager. I want to announce that...");
      }
      public List<Student> GetStudents()
      {
         return students;
      }
      public List<Teacher> GetTeachers()
      {
         return teachers;
      }
   }
}
