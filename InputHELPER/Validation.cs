using System;

namespace InputHelper
{
    public class Validation
    {
        public static void InputDataIsValid(int number)
        {
            Console.WriteLine("Enter a number");
            try {
                number = Int32.Parse(Console.ReadLine());
                if(number < 0) {
                    Console.WriteLine("Negative number is not allowed!");

                }
            }catch(FormatException ex) {
                Console.WriteLine("Not number"+ex);
                InputDataIsValid(number);
            }
           
           
        }

        public static void InputDataIsValid(ref string text)
        {
            while (string.IsNullOrEmpty(text)) {
                Console.WriteLine("Text can't be empty! Input your text once more");
                text= Console.ReadLine();
            }
        }


        
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
