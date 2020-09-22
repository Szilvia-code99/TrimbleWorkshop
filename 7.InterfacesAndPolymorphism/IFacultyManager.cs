using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
   /// <summary>
   /// Interface for faculty manager
   /// </summary>
   public interface IFacultyManager
   {
      /// <summary>
      /// Method for makin announcements
      /// </summary>
      void MakeAnnouncement();

      /// <summary>
      /// method for returning list of students
      /// </summary>
      /// <returns></returns>
      List<Student> GetStudents();

      /// <summary>
      /// method for returning list of teachers
      /// </summary>
      /// <returns></returns>
      List<Teacher> GetTeachers();
   }
}