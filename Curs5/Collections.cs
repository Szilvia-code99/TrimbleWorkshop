using System;
using System.Collections.Generic;
using System.Linq;
using UserInputValidator;

namespace Collections
{
      ///<summary>
      ///Create a program that has 2 options for the user:
      ///To display a list of 4 names of teachers(when the user types “1” from keyboard)
      ///To display a list of 6 names of students(when the user types “2” from keyboard)(both lists will be strings).
      ///Create a program that returns the following from different type of collections : 
      ///maximum and minimum element
      ///sum of all elements
      ///count of prime numbers
      ///Average value of the prime numbers
      ///</summary> 

   class Collections
    {
      ///<summary>
      ///Function to validate user entered options
      ///</summary> 
      public static void ChooseOption(ref int option)
      {
         do {

            Console.WriteLine("1. Display teacher names");
            Console.WriteLine("2. Display student names");
            Console.WriteLine("3. Exit");
            UserInputValidation.ValidateUserInput(ref option, "Choose an option");
            Console.WriteLine();

         } while (!(option == 1 || option == 2 || option == 3));
      }

      ///<summary>
      ///Function to decide whether a number is prime or not
      ///</summary> 
      public static bool IsPrime(int number)
      {
         int m = 0;
         m = number / 2;
         for (int i = 2; i <= m; i++) {
            if (number % i == 0) {
               return false;
            }
         }
         return true;
      }

      ///<summary>
      ///Function to count prime numbers in list
      ///</summary> 
      public static int CountPrimeNumbers(List<int> list)
      {
         int primeNumbersCount = 0;
         if (list.Count == 0) {
            return primeNumbersCount;
         }
         foreach(int number in list) {
             if (IsPrime(number)) {
               primeNumbersCount++;
              }
          }
         return primeNumbersCount;
      }

      ///<summary>
      ///Function to count prime numbers in array
      ///</summary> 
      public static int CountPrimeNumbers(int[] array)
      {
         int primeNumbersCount = 0;
         if (array.Length == 0) {
            return primeNumbersCount;
         }
         foreach (int number in array) {
            if (IsPrime(number)) {
               primeNumbersCount++;
            }
         }
         return primeNumbersCount;
      }

      ///<summary>
      ///Function to count prime numbers in dictionary
      ///</summary> 
      public static int CountPrimeNumbers(Dictionary<string,int> dictionary)
      {
         int primeNumbersCount = 0;
         if (dictionary.Count == 0) {
            return primeNumbersCount;
         }
         foreach (int number in dictionary.Values) {
            if (IsPrime(number)) {
               primeNumbersCount++;
            }
         }
         return primeNumbersCount;
      }

      ///<summary>
      ///Function to calculate average of prime numbers in dictionary
      ///</summary> 
      public static float AverageOfPrimes(Dictionary<string, int> dictionary)
      {
         float average = 0.0F;
         if (dictionary.Count == 0) {
            return average;
         }
         foreach (int number in dictionary.Values) {
            if (IsPrime(number)) {
               average+=number;
            }
         }
         return average/ CountPrimeNumbers(dictionary);
      }

      ///<summary>
      ///Function to calculate average of prime numbers in array
      ///</summary> 
      public static float AverageOfPrimes(int[] array)
      {
         float average = 0.0F;
         if (array.Length == 0) {
            return average;
         }
         foreach (int number in array) {
            if (IsPrime(number)) {
               average += number;
            }
         }
         return average / CountPrimeNumbers(array);
      }

      ///<summary>
      ///Function to calculate average of prime numbers in list
      ///</summary> 
      public static float AverageOfPrimes(List<int> list)
      {
         float average = 0.0F;
         if (list.Count == 0) {
            return average;
         }
         foreach (int number in list) {
            if (IsPrime(number)) {
               average += number;
            }
         }
         return average / CountPrimeNumbers(list);
      }

      static void Main(string[] args)
        {

         List<string> teachers = new List<string> { "Mr.Poppins", "Ms.Jackson", "Mss. Blueberry", "Mr.Alabama" };
         List<string> students = new List<string> { "Alan","Karen","Bobby","Vanessa","Kate","Lindsay"};

         int option = 0;

         do {
            ChooseOption(ref option);
            switch (option) {
               case 1:
                  foreach(string teacher in teachers){
                     Console.WriteLine(teacher);
                     Console.WriteLine();
                  }
                  break;
               case 2:
                  foreach (string student in students) {
                     Console.WriteLine(student);
                     Console.WriteLine();
                  }
                  break;
            }
         } while (option != 3);

         List<int> listNumbers = new List<int> { 1, 2, 4, 5, 2, 1, 50, 32 };
         int[] arrayNumbers = { 72, 482, 462, 46, 29, 26, 35, 3 };
         Dictionary<string,int>dictionaryNumbers=new Dictionary<string, int> { { "cabbage", 1 }, { "corn", 472 }, { "apple", 5 }, { "beans", 94 }, { "pineapple", 88 } };

         Console.WriteLine($"Maximum of list: {listNumbers.Max()} and minimum: {listNumbers.Min()}");
         Console.WriteLine($"Maximum of array: {arrayNumbers.Max()} and minimum: {arrayNumbers.Min()}");
         Console.WriteLine($"Maximum of dictionary: {dictionaryNumbers.Values.Max()} and minimum: {dictionaryNumbers.Values.Min()}");

         Console.WriteLine();
         Console.WriteLine($"Sum of list: {listNumbers.Sum()}");
         Console.WriteLine($"Sum of array: {arrayNumbers.Sum()}");
         Console.WriteLine($"Sum of dictionary: {dictionaryNumbers.Values.Sum()}");

         Console.WriteLine();
         Console.WriteLine($"Count of prime numbers in list: {CountPrimeNumbers(listNumbers)}");
         Console.WriteLine($"Count of prime numbers in array: {CountPrimeNumbers(arrayNumbers)}");
         Console.WriteLine($"Count of prime numbers in dictionary: {CountPrimeNumbers(dictionaryNumbers)}");

         Console.WriteLine();
         Console.WriteLine($"Average of prime numbers in list: {AverageOfPrimes(listNumbers)}");
         Console.WriteLine($"Average of prime numbers in array: {AverageOfPrimes(arrayNumbers)}");
         Console.WriteLine($"Average of prime numbers in dictionary: {AverageOfPrimes(dictionaryNumbers)}");
      }
    }
}