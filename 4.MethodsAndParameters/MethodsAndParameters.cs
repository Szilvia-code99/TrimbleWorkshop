using System;
using UserInputValidator;

namespace MethodsAndParameters
{
   ///<summary>
   ///Write a C# program with the following requirements:
   ///calculate the area of a circle
   ///calculate the area of a rectangle
   ///calculate the area of a cylinder
   ///Calculations should be done based on the option entered and with the dimensions provided by the user from the keyboard.
   ///</summary> 
   class MethodsAndParameters
   {
      ///<summary>
      ///Function calculates the area of a circle
      ///</summary> 
      public static void Area(float circleRadius)
      {
         double surface = Math.PI * Math.Pow(circleRadius, 2);
         Console.WriteLine("The area of the circle is {0:F2}", surface);
      }

      ///<summary>
      ///Function calculates the area of a rectangle
      ///</summary>
      public static void AreaRectangle(float widthOfRectangle, float heightOfRectangle)
      {
         double surface = widthOfRectangle * heightOfRectangle;
         Console.WriteLine("The area of the rectangle is {0:F2}", surface);
      }

      ///<summary>
      ///Function calculates the area of a cylinder
      ///</summary>
      public static void Area(float cylinderRadius, float heightOfCylinder)
      {
         double surface = 2 * Math.PI * Math.Pow(cylinderRadius, 2) + heightOfCylinder * (2 * Math.PI * cylinderRadius);
         Console.WriteLine("The area of the cylinder is {0:F2}", surface);
      }

      ///<summary>
      ///Function that read in and validates the option of the user
      ///</summary>
      public static void ChooseOption(ref int option)
      {
         do {

            Console.WriteLine("1. Calculate the area of a circle");
            Console.WriteLine("2. Calculate the area of a rectangle");
            Console.WriteLine("3. Calculate the area of a cylinder");
            Console.WriteLine("4. Exit");
            UserInputValidation.ValidateUserInput(ref option, "Choose an option");

         } while (!(option == 1 || option == 2 || option == 3 || option == 4));
      }

      static void Main(string[] args)
      {
         int option = 0;

         do {
            ChooseOption(ref option);
            switch (option) {
               case 1:
                  float circleRadius = 0;
                  UserInputValidation.ValidateUserInputRadius(ref circleRadius, "Enter the radius of the circle");
                  Area(circleRadius);
                  break;
               case 2:
                  float widthOfTheRectangle = 0;
                  UserInputValidation.ValidateUserInput(ref widthOfTheRectangle, "Enter the width of the rectangle");
                  float heightOfTheRectangle = 0;
                  UserInputValidation.ValidateUserInput(ref heightOfTheRectangle, "Enter the height of the rectangle");
                  AreaRectangle(widthOfTheRectangle, heightOfTheRectangle);
                  break;
               case 3:
                  float cylinderRadius = 0;
                  UserInputValidation.ValidateUserInputRadius(ref cylinderRadius, "Enter the radius of the cylinder");
                  float cylinderHeight = 0;
                  UserInputValidation.ValidateUserInput(ref cylinderHeight, "Enter the height of the cylinder");
                  Area(cylinderRadius, cylinderHeight);
                  break;
            }
         } while (option != 4);
      }
   }
}