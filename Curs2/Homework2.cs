using System;
using InputHelper;

namespace Curs2
{ 
    ///<summary>
    /// 1. Write a program that specifies the odd and even numbers between 0 and a value entered by the user.
    /// 2. Write a program that specifies if a grade is excellent, very good, good, average or fail. The program should be implemented using switch statement.
    /// 3. Write a program that counts user specified symbols in a string read as input.
    /// Find all the “1s” in: “1, 2, 1, 2, 3, 4, 3, 1”
    /// The program should be implemented in multiple ways: using all type of learned loops	
    /// 4. Write a program that checks if a string is palindrome (= strings that can be read equally from right to left, such as 'kayak', ‘ANNA’).
    ///</summary> 
    
    class Homework2
    {
        ///<summary>
        ///First printing out the even numbers from 0 to number given by user, then the odd numbers
        ///</summary>
        /// <param name="number"></param>
        public static void OddAndEvenNumbers(int number)
        {
                if(number==0) {
                 Console.WriteLine("The even numbers are: 0");
                }
                Console.WriteLine("The even numbers are: ");
                for (int i = 0; i <= number; i++) {
                    if (i % 2 == 0) {
                        Console.WriteLine($"{i} ");
                    }
                }
                Console.WriteLine("The odd numbers are: ");
                for (int i = 0; i <= number; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine($"{i} ");
                    }
                }
        }

        ///<summary>
        //Specifying if a grade is excellent, very good, good, average or fail. 
        ///</summary>
        /// <param name="grade"></param>
        public static void SpecifyGrade(int grade)
        {
            var result = grade switch
            {
                1 => "Fail",
                2 => "Fail",
                3 => "Fail",
                4 => "Fail",
                5 => "Average",
                6 => "Average",
                7 => "Good",
                8 => "Good",
                9 => "Very Good",
                10 => "Excellent",
                _ => "Grade should be between 0 and 10"
            };
            Console.WriteLine(result);
        }

        ///<summary>
        ///Count number of occurences of symbol in given string
        ///</summary>
        /// <param name="userInput"></param>
        /// <param name="symbol"></param>
        public static void FindOccurencesOfSymbolInString(string userInput, char symbol)
        {
            int count = 0;
            foreach (char c in userInput)
                if (c == symbol) {
                    count++;
                }

            int count1 = 0;
            for (int i= 0;i < userInput.Length;i++){
                if (userInput[i] == symbol) {
                    count1++;
                }
                }

            int count2 = 0, index=0;
            while(index<userInput.Length) {
                if (userInput[index] == symbol) {
                    count2++;
                }
                index++;
            }

            index = 0;
            int count3 = 0;
            do {
                if (userInput[index] == symbol) { 
                    count3++;
                }
                index++;
            } while (index < userInput.Length);

            Console.WriteLine($"1. There are {count} of {symbol} in {userInput}");
            Console.WriteLine($"2. There are {count1} of {symbol} in {userInput}");
            Console.WriteLine($"3. There are {count2} of {symbol} in {userInput}");
            Console.WriteLine($"4. There are {count3} of {symbol} in {userInput}");
        }

        ///<summary>
        //Checking if a word is palindrom or not
        ///</summary>
        /// <param name="userInput"></param>
        public static bool isStringPalindrome(string userInput)
        {
            int length = 0;
            while (length < userInput.Length/2) {
                if (userInput[length] != userInput[userInput.Length-length-1]) {
                    return false;
                }
                length++;
            }
            return true;
        }

        /// <summary>
        /// Checking if a word is plaindrom or not
        /// </summary>
        /// <param name="userInput"></param>
        public static void RecursiveIsStringPalindrome2(string userInput)
        {
            if (userInput.Length <= 1 ) {
                Console.WriteLine("IS Palindrom");
                return;
            }
            if (userInput[0] != userInput[userInput.Length - 1]) {
                Console.WriteLine("Is NOT Palindrome");
                return;
            }

            RecursiveIsStringPalindrome2(userInput.Substring(1, userInput.Length - 2));
        }

        static void Main(string[] args)
        {
            int number=0;
            Validation.ValidateInputData(ref number,"Enter a number");

            OddAndEvenNumbers(number);
            Console.WriteLine();

            int grade = 0;
            Validation.ValidateInputData(ref grade, "Enter your grade");
            SpecifyGrade(grade);
            Console.WriteLine();

            string userInput="";
            Validation.ValidateInputData(ref userInput, "Enter your string ");
            char symbolToFindInUserInput = ' ';
            Validation.ValidateInputData(ref symbolToFindInUserInput, "Enter the symbol you want to find ");
            FindOccurencesOfSymbolInString(userInput, symbolToFindInUserInput);

            string userInput1 = "";
            Validation.ValidateInputData(ref userInput1, "Enter your string ");
            if (isStringPalindrome(userInput1)) {
                Console.WriteLine($"{userInput1} is Palindrom");
            } else {
                Console.WriteLine($"{userInput1} is NOT Palindrom");
            }

            RecursiveIsStringPalindrome2(userInput1);
        }
    }
}
