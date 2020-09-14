using System;


namespace Curs1
{
    class Program
    {
       public static void CalculateTriangle()
        {
            float baseAng1, baseAng2, vertexAngle, sum;
            //base angle,vertexangle
            Console.WriteLine("Enter the first base angle:");
            baseAng1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second base angle:");
            baseAng2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vertex angle:");
            vertexAngle = float.Parse(Console.ReadLine());

            // Calculate the sum of all angles of triangle 
            sum = baseAng1 + baseAng2 + vertexAngle;

            // Check whether sum=180 then its a valid triangle otherwise not 
            if (sum == 180) {
                Console.WriteLine("The triangle is valid.");
                //check whether the triangle is equilateral
                if (baseAng1 == 60 && baseAng2 == 60 && vertexAngle == 60) {
                    Console.WriteLine("The triangle is equilateral.");
                } else if (baseAng1 == baseAng2 || baseAng2 == vertexAngle || baseAng1 == vertexAngle) {
                    Console.WriteLine("The triangle is an isoscel.");
                } else {
                    Console.WriteLine("The triangle is scalene based.");
                }
            } else {
                Console.WriteLine("The triangle is not valid.");
            }
        }

       public static void CalculateSurface()
        {
            Console.WriteLine("Please enter the radius of the circle");
            int radius = Convert.ToInt32(Console.ReadLine());
            double surface = Math.PI * radius * radius;
            Console.WriteLine("The surface of the circle is, {0:F2}", surface);
        }

       public static void CalculateTemperature()
        {
            Console.WriteLine("Enter the temperatura in Celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temperatura in Kelvin");
            int kelvin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temperatura in Fahrenheit");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            float toKelvin = (float)celsius + (float)273.15;
            double toFahrenheit = celsius * 9 / 5 + 32;
            double toCelsiusFromKelvin = kelvin- 273.15;
            double toCelsiusFromFahr =  (fahrenheit-32)*5/9 ;

            Console.WriteLine(celsius + " celsius in kelvin is " + toKelvin);
            Console.WriteLine(celsius + " celsius in fahrenheit is " + toFahrenheit);
            Console.WriteLine(kelvin + " kelvin in celsius is " + toCelsiusFromKelvin);
            Console.WriteLine(fahrenheit + " fahrenheit in celsius is " + toCelsiusFromFahr);



        }
        static void Main(string[] args)
        {
            CalculateSurface();
            CalculateTemperature();
            CalculateTriangle();
        }
           
    }
}
