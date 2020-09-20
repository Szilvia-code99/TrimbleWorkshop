using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5Collections;
using System.Collections.Generic;

namespace CollectionsTests
{
   [TestClass]
   public class CollectionsTests
   {
      [TestMethod]
      public void IsPrimeTest()
      {
         //Arrange
         int prime = 7;

         //Assert & Act
        Assert.IsTrue(Collections.IsPrime(prime),"Number is prime");
      }


      [TestMethod]
      public void CountPrimeNumbersTest()
      {
         //Arrange
         List<int> numbers = new List<int> { 1, 7, 28, 29, 4, 5 };

         int countOfPrimes = 4;

         //Assert & Act
         Assert.AreEqual(countOfPrimes,Collections.CountPrimeNumbers(numbers));
      }
   }
}
