using System;
using System.Collections.Generic;
using System.Data;
using UserInputValidator;

namespace Exceptions
{
        ///<summary>
        ///Create a C# program : That reads an integer day number(between 1 and 365) from the console and converts this number into a month 
        ///and a day of the month and then prints the result to the console. 
        ///Few examples :  entering 40 should result in “February 9” being displayed.
        ///entering 186 should result in “July 5” being displayed
        ///entering 327 should result in “November 23” being displayed
        ///Detects whether the specified year from the console is a leap year.
        ///A year is a leap year if the following two statements are both true :   
        ///It is divisible by 4;
        ///It is either not divisible by 100, or it is divisible by 400;
        ///</summary> 
    class Exceptions
    {
        ///<summary>
        ///Function that calculates the month and the day based on the dayNumber of the year
        ///</summary> 
        public static void CalculateMonthAndDayFromDayNumber(List<int>months, ref string month, ref int day,ref int dayNumber)
        {
            int sum = 0;
            int monthNumber= 1;

            for (int i = 0; i < months.Count; i++) {
                sum = sum + months[i];
                if (dayNumber <= sum) {
                    if (i == 0) {
                        day = dayNumber;
                        break;
                    } else {
                        day = dayNumber - (sum - months[i]);
                        break;
                    }
                }
                monthNumber++;
            }

            month = GetMonthNameFromMonthNumber(monthNumber);

        }

        ///<summary>
        ///Function that returns the name of the month based on the number of the month
        ///</summary> 
        public static string GetMonthNameFromMonthNumber(int monthNumber)
        {
            var month = monthNumber switch
            {
                1 => Months.January.ToString(),
                2 => Months.February.ToString(),
                3 => Months.March.ToString(),
                4 => Months.April.ToString(),
                5 => Months.May.ToString(),
                6 => Months.June.ToString(),
                7 => Months.July.ToString(),
                8 => Months.August.ToString(),
                9 => Months.September.ToString(),
                10 => Months.October.ToString(),
                11 => Months.November.ToString(),
                12 => Months.December.ToString(),
            };
            return month;
        }

        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            int year = 0;
            UserInputValidation.ValidateUserInput(ref year, "Enter a year");
            bool IsLeapYear = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
            List<int> DaysInMonths = IsLeapYear ?
                     new List<int>{ 31,29,31,30,31,30,31,31,30,31,30,31} : 
                     new List<int>{ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int dayNumber = 0;
            string month = string.Empty;
            int day = 0;

            if (IsLeapYear) {
            while (!(dayNumber >= 1 && dayNumber <= 366)) {
               UserInputValidation.ValidateUserInput(ref dayNumber, "Enter a number between 1 and 366");
               CalculateMonthAndDayFromDayNumber(DaysInMonths, ref month, ref day, ref dayNumber);
                }
            } else { 
                while (!(dayNumber >= 1 && dayNumber <= 365)) {
                     UserInputValidation.ValidateUserInput(ref dayNumber, "Enter a number between 1 and 365");
                    CalculateMonthAndDayFromDayNumber(DaysInMonths, ref month, ref day, ref dayNumber);
                }
            }
            Console.WriteLine($"{month} {day}");
        }
    }
}