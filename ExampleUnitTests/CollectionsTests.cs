using _5Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ExampleUnitTests
{

   /// <summary>
   /// Unit tests class for collections class
   /// </summary>
   [TestFixture]
   public class CollectionsTests
   {
      /// <summary>
      /// Unit test for testing prime numbers
      /// </summary>
      [Test, Sequential]
      public void TestIsPrime_01_ValidPrimeNumbers([Values(7, 11, 15)] int primeNumber)
      {
         //Assert & Act
         Assert.IsTrue(Collections.IsPrime(primeNumber), "Number is prime");
      }
      [Test]
      public void TestIsPrime_02_NonPrimeNumbers()
      {
         //Arrange
         int prime = 6;

         //Assert & Act
         Assert.IsFalse(Collections.IsPrime(prime), "Number is NOT prime");
      }


      [Test]
      public void CountPrimeNumbers_01_CorrectlyCountPrimeNumbers()
      {
         //Arrange
         List<int> numbers = new List<int> { 1, 7, 28, 29, 4, 5 };

         int expectedCountOfPrimes = 4;
         int actualCountOfPrimes = Collections.CountPrimeNumbers(numbers);
         //Assert & Act
         Assert.AreEqual(expectedCountOfPrimes, actualCountOfPrimes);
      }

      [Test]
      public void CountPrimeNumbers_02_IncorrectlyCountPrimeNumbers()
      {
         //Arrange
         List<int> numbers = new List<int> { 1, 7, 28, 29, 4, 5 };

         int expectedCountOfPrimes = 7;
         int actualCountOfPrimes = Collections.CountPrimeNumbers(numbers);

         //Assert & Act
         Assert.AreNotEqual(expectedCountOfPrimes, actualCountOfPrimes, "Not equal");
      }
   }
}