using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
   /// <summary>
   /// Write a program that models 2 vehicles (Car / Truck) and simulates driving and refueling them.
   ///both have fuel quantity, fuel consumption in liters per km and can be driven a given distance and refueled with a given amount of fuel.
   ///input the necessary data about the vehicles and print after each drive command, the travelled distance, if there is enough fuel, or “Car/Truck needs refueling” otherwise.
   ///the truck has a tiny hole in its tank and when it's refueled it keeps only 95% of the given fuel. The car has no problems and adds all the given fuel to its tank.
   ///you can also take into account the factor of air conditioner
   /// </summary>
   public class InterfacesAndPolymorphism
   {

      static void Main(string[] args)
      {
         List<Teacher> teachers = new List<Teacher> {
            new Teacher("Anne","Marie",30,83262,5,"Biology"),
            new Teacher("Kate","Winslet",25,938274,8,"Mathematics"),
            new Teacher("Barbara", "Plavin", 26, 83737832,10, "Gymnastics"),
            new Teacher("Obama", "Barack", 55, 983262, 2,"Politics")
          };

         List<Student> students = new List<Student> {
            new Student("Romee","Strjid",21,98362,2,"Informatics"),
            new Student("Viktor","Orban",25,938274,3,"Politics"),
            new Student("Ion", "Cruza", 26, 83737832,4, "Architecture"),
            new Student("Jennifer", "Aniston", 40, 1983262,6, "Drama"),
            new Student("Mariah", "Carry", 50, 1283262,3, "Drama"),
            new Student("Tomas", "Kent", 18, 247262, 4,"Geography")
          };

          FacultyManager manager = new FacultyManager(students, teachers);

          List<Student> studentsList = manager.GetStudents();
          foreach(Student student in studentsList){
             student.GetDetail();
            }

          List<Teacher> teachersList = manager.GetTeachers();
          foreach(Teacher teacher in teachersList){
             teacher.GetDetail();
            }

         string vehicleChoice = String.Empty;
         do {
            while (vehicleChoice != "Car" && vehicleChoice != "Truck" && vehicleChoice != "Exit") {
               UserInputValidator.UserInputValidation.ValidateUserInput(ref vehicleChoice, "What do you want to drive? Car/Truck/Exit");
            }
            if (vehicleChoice == "Car") {
               Car car = new Car();
               string exit = string.Empty;
               do {
                  float fuel = 0.0F;
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref fuel, "How much fuel you have?");
                  car.AddMaxFuel(fuel);
                  car.DisplayDetails();
                  float distance = 0.0F;
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref distance, "How many km do you want to drive?");
                  car.Drive(distance);
                  car.DisplayDetails();
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref exit, "Do you want to drive the car again? Y/N");
               } while (exit != "Y");
            } else {
               Truck truck = new Truck();
               string exit = string.Empty;
               do {
                  float fuel = 0.0F;
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref fuel, "How much fuel you have?");
                  truck.AddMaxFuel(fuel);
                  truck.DisplayDetails();
                  float distance = 0.0F;
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref distance, "How many km do you want to drive?");
                  truck.Drive(distance);
                  truck.DisplayDetails();
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref exit, "Do you want to drive the car again? Y/N");
               } while (exit != "Y");
            }
         } while (vehicleChoice != "exit");
      }
   }
}
