using System;
using InputHelper;

namespace Curs4
{
    ///<summary>
    ///Write a C# program with the following requirements:
    ///calculate the area of a circle
    ///calculate the area of a rectangle
    ///calculate the area of a cylinder
    ///Calculations should be done based on the option entered and with the dimensions provided by the user from the keyboard.
    ///</summary> 
    class Homework4
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
        public static void Area(float widthOfRectangle,float heightOfRectangle,string rectangle)
        {
            double surface =  widthOfRectangle * heightOfRectangle;
            Console.WriteLine("The area of the rectangle is {0:F2}", surface);
        }

        ///<summary>
        ///Function calculates the area of a cylinder
        ///</summary>
        public static void Area(float cylinderRadius, float heightOfCylinder)
        {
            double surface = 2 * Math.PI * Math.Pow(cylinderRadius,2) + heightOfCylinder*(2 * Math.PI * cylinderRadius);
            Console.WriteLine("The area of the cylinder is {0:F2}", surface);
        }
        static void Main(string[] args)
        {
            int opHtion = 0;

            while(!(option==1 || option==2 || option == 3)) {

                Console.WriteLine("1. Calculate the area of a circle");
                Console.WriteLine("2. Calculate the area of a rectangle");
                Console.WriteLine("3. Calculate the area of a cylinder");
                Validation.ValidateInputData(ref option,"Choose an option");
            }

            switch(option){
                case 1:
                    float circleRadius = 0;
                    Validation.ValidateInputDataRadius(ref circleRadius,"Enter the radius of the circle");
                    Area(circleRadius);
                    break;
                case 2:
                    float widthOfTheRectangle = 0;
                    Validation.ValidateInputData(ref widthOfTheRectangle, "Enter the width of the rectangle");
                    float heightOfTheRectangle = 0;
                    Validation.ValidateInputData(ref heightOfTheRectangle, "Enter the height of the rectangle");
                    Area(widthOfTheRectangle,heightOfTheRectangle,"rectangle");
                    break;
                case 3:
                    float cylinderRadius = 0;
                    Validation.ValidateInputDataRadius(ref cylinderRadius, "Enter the radius of the cylinder");
                    float cylinderHeight = 0;
                    Validation.ValidateInputData(ref cylinderHeight, "Enter the height of the cylinder");
                    Area(cylinderRadius, cylinderHeight);
                    break;
            }
        }
    }
}
