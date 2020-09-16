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
        public static void ValidateInputData(ref int number,string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = Int32.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateInputData(ref number, askFromUser);
                }
            } catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateInputData(ref number, askFromUser);
            } catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateInputData(ref number, askFromUser);
            }
        }

        public static void ValidateInputData(ref double number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = Double.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateInputData(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateInputData(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateInputData(ref number, askFromUser);
            }
        }

        public static void ValidateInputDataRadius(ref float number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = float.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateInputData(ref number, askFromUser);
                }
                if (number > 180) {
                    Console.WriteLine("Radius above 180 is not allowed!");
                    ValidateInputData(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateInputData(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateInputData(ref number, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a number entered by the user is a valid number(float) and if it is a positive number
        ///</summary>
        public static void ValidateInputData(ref float number, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                number = float.Parse(Console.ReadLine());
                if (number < 0) {
                    Console.WriteLine("Negative number is not allowed!");
                    ValidateInputData(ref number, askFromUser);
                }
            }
            catch (FormatException ex) {
                Console.WriteLine("Not a valid number");
                ValidateInputData(ref number, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine("Not a valid numerical value!");
                ValidateInputData(ref number, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a text entered by the user is a valid string and if it is not null or empty
        ///</summary>
        public static void ValidateInputData(ref string text,string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                text = Console.ReadLine();
                if (string.IsNullOrEmpty(text)) {
                    Console.WriteLine("Text can't be empty!");
                    ValidateInputData(ref text, askFromUser);
                }
            }catch (Exception ex) {
                Console.WriteLine(ex);
                ValidateInputData(ref text, askFromUser);
            }
        }

        ///<summary>
        ///Checking if a character entered by the user is a valid chararacter and if it is not '/0' (null)
        ///</summary>
        public static void ValidateInputData(ref char character, string askFromUser)
        {
            Console.WriteLine(askFromUser);
            try {
                character = char.Parse(Console.ReadLine());
                if (character == ' ') {
                    Console.WriteLine("Character can't be empty!");
                    ValidateInputData(ref character, askFromUser);
                }
            }
            catch(FormatException) {
                Console.WriteLine("Not a character");
                ValidateInputData(ref character, askFromUser);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                ValidateInputData(ref character, askFromUser);
            }
        }
    }
}
