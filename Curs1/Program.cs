using System;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter the radius of the circle");
           int radius= Convert.ToInt32(Console.ReadLine());
           double area = Math.PI * radius * radius;
           Console.WriteLine("The area of the circle is "+area);
         //  Console.ReadKey();


        }
    }
}
