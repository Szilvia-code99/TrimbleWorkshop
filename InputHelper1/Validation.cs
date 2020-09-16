using System;

namespace InputHelper
{
    ///<summary>
    ///This class is created for validating various user input(int, string, char) 
    ///</summary>
    public class Validation
    {
        ///<summary>
        ///Checking if a number entered by the user is a valid number(integer) and if it is a positive number
        ///</summary>
        public static void ValidateInputData(int number,string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = Int32.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateInputData(number, askFromUser);
                }
            } catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateInputData(number, askFromUser);
            } catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
            }
        }

        ///<summary>
        ///Checking if a text entered by the user is a valid string and if it is not null or empty
        ///</summary>
        public static void ValidateInputData(string text,string askFromUser)
        {
            Console.WriteLine(askFromUser);
            text = Console.ReadLine();
            if (string.IsNullOrEmpty(text)) {
                Console.WriteLine("Text can't be empty!");
                ValidateInputData(text,askFromUser);
            }
        }

        ///<summary>
        ///Checking if a character entered by the user is a valid chararacter and if it is not '/0' (null)
        ///</summary>
        public static void ValidateInputData(char character, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                character = char.Parse(Console.ReadLine());
                if (character == ' ') {
                    Console.WriteLine("Character can't be empty!");
                    ValidateInputData(character, askFromUser);
                }
            }
            catch(FormatException) {
                Console.WriteLine("Not a character");
                ValidateInputData(character, askFromUser);
            }
        }
    }
}
