using System;

///<summary>

/// 1. Create a console app that can calculate the surface of a circle. The radius of the circle should be read from keyboard input.
/// 2. Create a console app that converts Celsius degrees to Kelvin and Fahrenheit and vice-versa.
/// 3. Create a console app that checks whether a triangle can be formed by the entered angle values and prints whether the triangle is equilateral, 
/// isosceles or scalene based on the entered side length values.

///</summary> 

namespace Course1
{
   
    class Homework1
    {
        //Reading the 3 angles of a triangle, deciding whether the triangle is valid, and printing equilateral, isosceles or scalene based 
       public static void CalculateTriangle()
        {
            float baseAngle1, baseAngle2, vertexAngle, sum;
            //base angle,vertexangle
            Console.WriteLine("Enter the first base angle:");
            baseAngle1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second base angle:");
            baseAngle2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vertex angle:");
            vertexAngle = float.Parse(Console.ReadLine());

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

        //calculating the surface of a circle based on the given radius
       public static void CalculateSurface()
        {
            Console.WriteLine("Please enter the radius of the circle");
            double circleRadius = Double.Parse(Console.ReadLine());
            double surface = Math.PI * Math.Pow(circleRadius,2);
            Console.WriteLine("The surface of the circle is, {0:F2}", surface);
        }

        //convert celsius to fahrenheit and kelvin and vice-versa
       public static void CalculateTemperature()
        {
            Console.WriteLine("Enter the temperature in Celsius");
            float temperatureInCelsiusDegree = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the temperature in Kelvin");
            float temperatureInKelvin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the temperature in Fahrenheit");
            float temperatureInFahrenheit = float.Parse(Console.ReadLine());

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
