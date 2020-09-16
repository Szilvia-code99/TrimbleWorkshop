using System;
using System.Collections.Generic;
using System.Linq;

namespace App1._6
{
    class ProgramDebug
    {
        //general variables used in this program's functions
        private static string _input;
        private static readonly List<string> allowedValues = new List<string>(new[] { "1", "sort", "operate", "2" });
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, programmers!");
            Console.WriteLine("To close the program, type 'exit'!");

            while (true)
            {
                ProcessRequest();

                if (allowedValues.GetRange(0, 2).Contains(_input))
                {
                    Sort();
                }
                else if (allowedValues.GetRange(2, 2).Contains(_input))
                {
                    Operate();
                }
                Console.WriteLine("\n Done! \n");
            }
        }
        
        private static void Sort()
        {
            Console.WriteLine("Write down the words and separate them with a comma.");

            string request = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(request))
            {
                Console.WriteLine("An error occurred! \n \n"); //Can't figure out what you want 
                ProcessRequest();
            }
            if (IsExitSequence(request))
            {
                Environment.Exit(0);
            }

            List<string> words = request.Split(',').ToList();
            words.Sort();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        
        private static void Operate()
        {
            Console.WriteLine("Insert the two operands separately: \n");
            string op1 = Console.ReadLine();
            string op2 = Console.ReadLine();
            Console.WriteLine("Insert the operator: ");
            string operatorType = Console.ReadLine();

            int x, y, result = 0;

            //cast op1 and op2 to int type
            Int32.TryParse(op1, out x);
            Int32.TryParse(op2, out y);

            switch (operatorType)
            {
                case "+":
                    result = x + y;
                    result++;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }
            Console.WriteLine(result);
        }
        
        private static void ProcessRequest()
        {
            Console.WriteLine("Select a task:");
            Console.WriteLine("1. Sort words");
            Console.WriteLine("2. Operate numbers");

            string request = string.Empty;

            if (string.IsNullOrWhiteSpace(request))
            {
                Console.WriteLine("An error occurred! \n \n"); //Can't figure out what you want.
                ProcessRequest();
            }

            if (IsExitSequence(request))
            {
                //close the program
                Environment.Exit(0);
            }

            request = request.ToLower();

            if (allowedValues.Contains(request))
            {
                _input = request;
            }
        }
             
        private static bool IsExitSequence(string sequence)
        {
            if (string.IsNullOrWhiteSpace(sequence))
            {
                return false;
            }
            else if (sequence.ToLower().Trim().Equals("Finish"))
            {
                return true;
            }

            return false;
        }
    }
}
