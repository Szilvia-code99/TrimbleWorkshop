using System;

namespace UserInputValidator
{
    ///<summary>
    ///This class is created for validating various user input(int, string, char) 
    ///</summary>
    public class UserInputValidation
    {
        ///<summary>
        ///Checking if a number entered by the user is a valid number(integer) and if it is a positive number
        ///</summary>
        public static void ValidateUserInput(ref int number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = Int32.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateUserInput(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateUserInput(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateUserInput(ref number, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a number entered by the user is a valid number(double) and if it is a positive number
        ///</summary>
        public static void ValidateUserInput(ref double number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = double.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateUserInput(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateUserInput(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateUserInput(ref number, askFromUser);
            }
        }
        ///<summary>
        ///Checking if a radius entered by the user is a valid radius(float) and if it is a positive number
        ///</summary>
        public static void ValidateUserInputRadius(ref float number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = float.Parse(Console.ReadLine());
                if (number < 0 || number > 180) {
                    Console.WriteLine("The number should be between 0 and 180");
                    ValidateUserInput(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateUserInput(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateUserInput(ref number, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a number entered by the user is a valid number(float) and if it is a positive number
        ///</summary>
        public static void ValidateUserInput(ref float number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = float.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateUserInput(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateUserInput(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateUserInput(ref number, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a text entered by the user is a valid string and if it is not null or empty
        ///</summary>
        public static void ValidateUserInput(ref string text, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                text = Console.ReadLine();
                if (string.IsNullOrEmpty(text)) {
                    Console.WriteLine("Text can't be empty!");
                    ValidateUserInput(ref text, askFromUser);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                ValidateUserInput(ref text, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a character entered by the user is a valid chararacter and if it is not '/0' (null)
        ///</summary>
        public static void ValidateUserInput(ref char character, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                character = char.Parse(Console.ReadLine());
                if (char.IsWhiteSpace(character)) {
                    Console.WriteLine("Character can't be empty!");
                    ValidateUserInput(ref character, askFromUser);
                }
            }
            catch (FormatException) {
                Console.WriteLine("Not a character");
                ValidateUserInput(ref character, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                ValidateUserInput(ref character, askFromUser);
            }
        }
    }
}