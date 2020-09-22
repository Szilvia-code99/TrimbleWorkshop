using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5Collections;
using System.Collections.Generic;

namespace ExampleUnitTests
{
   /// <summary>
   /// Unit tests class for collections class
   /// </summary>
   [TestClass]
   public class CollectionsTests
   {
      /// <summary>
      /// Unit test for testing prime numbers
      /// </summary>
      [TestMethod]
     // [Sequential]
      public void TestIsPrime_01_ValidPrimeNumbers()
      {
         //Arrange
         int prime = 7;

         //Assert & Act
        Assert.IsTrue(Collections.IsPrime(prime),"Number is prime");
      }
      [TestMethod]
      public void TestIsPrime_02_NonPrimeNumbers()
      {
         //Arrange
         int prime = 6;

         //Assert & Act
         Assert.IsFalse(Collections.IsPrime(prime), "Number is NOT prime");
      }


      [TestMethod]
      public void CountPrimeNumbers_01_CorrectlyCountPrimeNumbers()
      {
         //Arrange
         List<int> numbers = new List<int> { 1, 7, 28, 29, 4, 5 };

         int expectedCountOfPrimes = 4;
         int actualCountOfPrimes = Collections.CountPrimeNumbers(numbers);
         //Assert & Act
         Assert.AreEqual(expectedCountOfPrimes, actualCountOfPrimes);
      }

      [TestMethod]
      public void CountPrimeNumbers_02_IncorrectlyCountPrimeNumbers()
      {
         //Arrange
         List<int> numbers = new List<int> { 1, 7, 28, 29, 4, 5 };

         int expectedCountOfPrimes = 7;
         int actualCountOfPrimes = Collections.CountPrimeNumbers(numbers);

         //Assert & Act
         Assert.AreNotEqual(expectedCountOfPrimes,actualCountOfPrimes,"Not equal" );
      }
   }
}
