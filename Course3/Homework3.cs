using System;
using System.Collections.Generic;
using System.Data;
using InputHelper;

namespace Course3
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
    class Homework3
    {
        
        ///<summary>
        ///Check if the entered year is a leap year or not
        ///</summary> 
        public static bool IsLeapYear(int year)
        {
            // If a year is multiple of 400,    
            // then it is a leap year  
            if (year % 400 == 0) {
                return true;
            }

            // Else If a year is multiple of 100,  
            // then it is not a leap year  
            if (year % 100 == 0) {
                return false;
            }

            // Else If a year is multiple of 4,  
            // then it is a leap year  
            if (year % 4 == 0) {
                return true;
            }

            return false;
        }


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
            List<int> leapYearMonths = new List<int> {31,29,31,30,31,30,31,31,30,31,30,31};
            List<int> notLeapYearMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int year = 0;
            string month="";
            int day = 0;
            int dayNumber =0;

            Validation.ValidateInputData(ref year, "Enter a year");
            if (IsLeapYear(year)) {
                while(!(dayNumber>=1 && dayNumber<=366)) {
                  Validation.ValidateInputData(ref dayNumber, "Enter a number between 1 and 366");
                    CalculateMonthAndDayFromDayNumber(leapYearMonths, ref month, ref day, ref dayNumber);

                }
            } else {
                while (!(dayNumber >= 1 && dayNumber <= 365)) {
                    Validation.ValidateInputData(ref dayNumber, "Enter a number between 1 and 365");
                    CalculateMonthAndDayFromDayNumber(notLeapYearMonths, ref month, ref day, ref dayNumber);
                }
            }

            Console.WriteLine($"{month} {day}");
        }
    }
}
