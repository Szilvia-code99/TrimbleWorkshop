using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorsAndLoops1;

namespace ExampleUnitTests
{
   /// <summary>
   /// Unit tests class for OperatorsAndLoops class
   /// </summary>
   [TestClass]
   public class OperatorsAndLoopsTests
   {
      /// <summary>
      /// Unit test for isStringPlaindrome method(test forr when is true)
      /// </summary>
      [TestMethod]
      public void IsStringPalindrome_01_StringIsPalindrome()
      {
         //Arrange
         string text = "anna";
         //Assert & Act
         Assert.IsTrue(OperatorsAndLoops.isStringPalindrome(text),"String is palindrom");
      }

      /// <summary>
      /// Unit test for isStringPlaindrome method(test forr when is false)
      /// </summary>
      [TestMethod]
      public void IsStringPalindrome_02_StringIsNotPalindrome()
      {
         //Arrange
         string text = "jdhag";
         //Assert & Act
         Assert.IsFalse(OperatorsAndLoops.isStringPalindrome(text), "String is NOT palindrom");
      }
   }
}
