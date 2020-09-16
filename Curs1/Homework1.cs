using System;
using System.ComponentModel.DataAnnotations;
using InputHelper;

///<summary>

/// 1. Create a console app that can calculate the surface of a circle. The radius of the circle should be read from keyboard input.
/// 2. Create a console app that converts Celsius degrees to Kelvin and Fahrenheit and vice-versa.
/// 3. Create a console app that checks whether a triangle can be formed by the entered angle values and prints whether the triangle is equilateral, 
/// isosceles or scalene based on the entered side length values.

///</summary> 

namespace Curs1
{
   
    class Homework1
    {
        ///<summary>
        //Reading the 3 angles of a triangle, deciding whether the triangle is valid, and printing equilateral, isosceles or scalene based 
        ///</summary>
        public static void CalculateTriangle()
        {
            float baseAngle1=0, baseAngle2=0, vertexAngle=0, sum;
            //base angle,vertexangle
            Validation.ValidateInputData(ref baseAngle1, "Enter the first base angle:");
            Validation.ValidateInputData(ref baseAngle2, "Enter the second base angle:");
            Validation.ValidateInputData(ref vertexAngle, "Enter the vertex angle:");

            // Calculate the sum of all angles of triangle 
            sum = baseAngle1 + baseAngle2 + vertexAngle;

            // Check whether sum=180 then its a valid triangle otherwise not 
            if (sum == 180) {
                Console.WriteLine("The triangle is valid.");
                //check whether the triangle is equilateral
                if (baseAngle1 == 60 && baseAngle2 == 60 && vertexAngle == 60) {
                    Console.WriteLine("The triangle is equilateral.");
                } else if (baseAngle1 == baseAngle2 || baseAngle2 == vertexAngle || baseAngle1 == vertexAngle) {
                    Console.WriteLine("The triangle is an isosceles.");
                } else {
                    Console.WriteLine("The triangle is scalene based.");
                }
            } else {
                Console.WriteLine("The triangle is not valid.");
            }
        }

        ///<summary>
        //calculating the surface of a circle based on the given radius
        ///</summary>
        public static void CalculateSurface()
        {
            double circleRadius = 0;
            Validation.ValidateInputData(ref circleRadius, "Enter the radius of the circle");
            double surface = Math.PI * Math.Pow(circleRadius,2);
            Console.WriteLine("The surface of the circle is, {0:F2}", surface);
        }

        ///<summary>
        //convert celsius to fahrenheit and kelvin and vice-versa
        ///</summary>
        public static void CalculateTemperature()
        {
            float temperatureInCelsiusDegree = 0, temperatureInKelvin=0, temperatureInFahrenheit=0;
            Validation.ValidateInputData(ref temperatureInCelsiusDegree, "Enter the temperature in Celsius");
            Validation.ValidateInputData(ref temperatureInKelvin, "Enter the temperature in Kelvin");
            Validation.ValidateInputData(ref temperatureInFahrenheit, "Enter the temperature in Fahrenheit");

            float temperatureConversionCelsiusToKelvin = (float)temperatureInCelsiusDegree + (float)273.15;
            double temperatureConversionCelsiusToFahrenheit = temperatureInCelsiusDegree * 9 / 5 + 32;
            double temperatureConversionKelvinsToCelsius = temperatureInKelvin- 273.15;
            double temperatureConversionFahrenheitToCelsius =  (temperatureInFahrenheit-32)*5/9 ;

            Console.WriteLine("{0} °C in Kelvin is {1}K ", temperatureInCelsiusDegree,temperatureConversionCelsiusToKelvin);
            Console.WriteLine($"{temperatureInCelsiusDegree} °C  celsius in fahrenheit is {temperatureConversionCelsiusToFahrenheit:F2}");
            Console.WriteLine("{0} Kelvin in celsius is {1}",temperatureInKelvin, temperatureConversionKelvinsToCelsius);
            Console.WriteLine($"{temperatureInFahrenheit} °F in celsius is {temperatureConversionFahrenheitToCelsius}");
        }

        static void Main(string[] args)
        {
            CalculateSurface();
            CalculateTemperature();
            CalculateTriangle();
        }
    }
}
