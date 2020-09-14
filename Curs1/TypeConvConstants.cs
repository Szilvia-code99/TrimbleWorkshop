using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1._2
{
    class Program
    {
        //Type Conversion
        void Main(string[] args)
        {
            //Explicit Conversion
            double width = 25.28;
            int i;

            // cast double to int.
            i = (int)width;
            Console.WriteLine(i); // 25

            // Type Conversion Methods: ToBoolean, ToChar, ToDateTime, ToString
            int x = 75;
            double y = 2345.7652;
            bool b = true;

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine("Insert number: ");
            
            //Variables:
            int a = 5; // initializing a
            string str = "C#"; // initializing str

            //Accepting Values from User
            string valueFromUser = Console.ReadLine();
            Console.WriteLine(valueFromUser);  // as string

            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);         // as int

            //Constants:
            const double pi = 3.141516;
            const string STABIXPERIENCE = "StabiXperience";
            const int employees = 115;
            Console.WriteLine(pi);      
            Console.WriteLine(STABIXPERIENCE);
            Console.WriteLine(employees);
            Console.ReadKey();
        }
    }
}

