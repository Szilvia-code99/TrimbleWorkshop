using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputValidator
{
   /// <summary>
   /// Class that displays the options validates the users option
   /// </summary>
   public class UserOptionValidation
   {
      /// <summary>
      /// Method for reading in users option and validating it
      /// </summary>
      /// <param name="option"></param>
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

   }
}
