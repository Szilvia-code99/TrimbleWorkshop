using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using UserInputValidator;

namespace Collections
{
   ///<summary>
   ///1.Create a program that has 2 options for the user:
   ///To display a list of 4 names of teachers(when the user types “1” from keyboard)
   ///To display a list of 6 names of students(when the user types “2” from keyboard)(both lists will be strings).
   ///2.Create a program that returns the following from different type of collections : 
   ///maximum and minimum element
   ///sum of all elements
   ///count of prime numbers
   ///Average value of the prime numbers
   ///3.Create an identity matrix with the square size 15:15 and display it.
   ///An identity matrix is an empty matrix with  ones on the principal diagonal.
   ///4.Write a program that multiplies two matrices with the square size 4:4 
   ///5.Write a program that randomly decides a winner out of 10 competitors and displays the name of the first two.
   ///Tip: use a random generator for deciding the winner
   ///</summary> 

   class Collections
   {
      ///<summary>
      ///Function to validate user entered options
      ///</summary> 
     

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
         foreach (int number in list) {
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
      public static int CountPrimeNumbers(Dictionary<string, int> dictionary)
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
               average += number;
            }
         }
         return average / CountPrimeNumbers(dictionary);
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

      /// <summary>
      /// Multiplying two square matrixes
      /// </summary>
      /// <param name="first"></param>
      /// <param name="second"></param>
      /// <param name="size"></param>
      /// <returns></returns>
      public static int[,] MultiplyTwoMatrices(int[,] first, int[,] second, int size)
      {
         int[,] result = new int[size, size];
         for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
               result[i, j] = 0;
            }
         }

         int sum = 0;
         for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
               sum = 0;
               for (int k = 0; k < size; k++)
                  sum = sum + first[i, k] * second[k, j];
               result[i, j] = sum;
            }
         }
         return result;
      }

      /// <summary>
      /// Displaying a square matrix
      /// </summary>
      /// <param name="a"></param>
      /// <param name="size"></param>
      public static void DisplayMatrix(int[,] a,int size)
      {
         for (int i = 0; i <size; i++) {
            for (int j = 0; j < size; j++) {
               Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
         }
      }

      static void Main(string[] args)
      {
         //1.Problem
         List<string> teachers = new List<string> { "Mr.Poppins", "Ms.Jackson", "Mss. Blueberry", "Mr.Alabama" };
         List<string> students = new List<string> { "Alan", "Karen", "Bobby", "Vanessa", "Kate", "Lindsay" };

         int option = 0;

         do {
            UserOptionValidation.ChooseOption(ref option);
            switch (option) {
               case 1:
                  foreach (string teacher in teachers) {
                     Console.WriteLine(teacher);
                  }
                  break;
               case 2:
                  foreach (string student in students) {
                     Console.WriteLine(student);
                  }
                  break;
            }
            Console.WriteLine();
         } while (option != 3);

         //2.Problem
         List<int> listNumbers = new List<int> { 1, 2, 4, 5, 2, 1, 50, 32 };
         int[] arrayNumbers = { 72, 482, 462, 46, 29, 26, 35, 3 };
         Dictionary<string, int> dictionaryNumbers = new Dictionary<string, int> { { "cabbage", 1 }, { "corn", 472 }, { "apple", 5 }, { "beans", 94 }, { "pineapple", 88 } };

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

         //3.Problem
         int[,] identityMatrix = new int[15, 15];

         for (int i = 0; i < 15; i++) {
            for (int j = 0; j < 15; j++) {
               //   if (i == j ? identityMatrix[i , j] = 0 : identityMatrix[i , j] = 1) {}
               if (i == j) {
                  identityMatrix[i, j] = 1;
               } else {
                  identityMatrix[i, j] = 0;
               }
            }
         }
         Console.WriteLine();
         Console.WriteLine("Identity Matrix: ");
         Console.WriteLine();
         DisplayMatrix(identityMatrix,15);

         //4.Problem
         int[,] a = { { 1, 4, 2, 6 }, { 2, 5, 1, 6 }, { 1, 2, 3, 4 }, { 3, 5, 2, 6 } };
         int[,] b = { { 3, 4, 2, 7 }, { 3, 5, 7, 8 }, { 1, 2, 1, 9 }, { 4, 6, 3, 7 } };
         int[,] result = MultiplyTwoMatrices(a, b, 4);

         Console.WriteLine();
         DisplayMatrix(a, 4);
         Console.WriteLine("   X   ");
         DisplayMatrix(b, 4);
         Console.WriteLine(" = ");
         DisplayMatrix(result,4);
         Console.WriteLine();

         //5.Problem
         List<string> players = new List<string> { "Szilvia", "Barbara", "Jennifer", "Romee", "Kate", "Cher", "Mr.Bean", "The Rock", "Snoop Dog", "Bilie Eilish" };
         Random random = new Random();
         int num = random.Next(0, 9);
         Console.WriteLine("The players are: ");
         foreach(string player in players) {
            Console.WriteLine($"{player}");
         }

         Console.WriteLine($"The winner is:{players[num]} ");
      }
   }
}