using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
   public interface IFacultyManager
   {
      void MakeAnnouncement();
      List<Student> GetStudents();
      List<Teacher> GetTeachers();

   }
}
