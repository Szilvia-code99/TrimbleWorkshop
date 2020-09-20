using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorsAndLoops1;

namespace OperatorsAndLoopsTests
{
   [TestClass]
   public class OperatorsAndLoopsTests
   {
      [TestMethod]
      public void  StringIsPalindrome()
      {
         //Arrange
         string text = "anna";
         //Assert & Act
         Assert.IsTrue(OperatorsAndLoops.isStringPalindrome(text),"String is palindrom");
      }

      [TestMethod]

      public void StringIsNotPalindrome()
      {
         //Arrange
         string text = "jdhag";
         //Assert & Act
         Assert.IsTrue(!OperatorsAndLoops.isStringPalindrome(text), "String is NOT palindrom");
      }
   }
}
