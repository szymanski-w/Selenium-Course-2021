using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SectionExam
{
    [TestClass]
    public class LeapYear
    {
        public static int year;

        public static int div_2;
        public static string is_odd;

        public static int div_4;
        public static string is_div_4;

        public static int div_100;
        public static string is_div_100;

        public static int div_400;
        public static string is_div_400;

        public static string isLeapYear;        

        [TestInitialize]
        public void TestInitialize()
        {
            year = 2020;

            div_2 = year % 2;
            if (div_2 != 0)
                is_odd = "yes";
            else
                is_odd = "no";

            div_4 = year % 4;
            if (div_4 == 0)
                is_div_4 = "yes";
            else
                is_div_4 = "no";

            div_100 = year % 100;
            if (div_100 == 0)
                is_div_100 = "yes";
            else
                is_div_100 = "no";

            div_400 = year % 400;
            if (div_400 == 0)
                is_div_400 = "yes";
            else
                is_div_400 = "no";
        }

        [TestMethod]
        public void TestMethod1()
        {
            if (div_2 == 0)
            {
                if (div_4 == 0)
                {
                    if (div_100 == 0)
                    {
                        if (div_400 == 0)
                        {
                            isLeapYear = "yes";
                        }
                        else
                            isLeapYear = "no";
                    }
                    else
                    {
                        if (div_400 == 0)
                        {
                            isLeapYear = "n/a";
                        }
                        else
                            isLeapYear = "yes";
                    }
                }
                else
                {
                    if (div_100 != 0 && div_400 != 0)
                        isLeapYear = "no";
                    else
                        isLeapYear = "n/a";
                }
            }
            else
                isLeapYear = "no";

            Console.WriteLine($"Odd year: {is_odd}\nDivisible by 4: {is_div_4}\nDivisible by 100: {is_div_100}\nDivisible by 400: {is_div_400}\n\n" +
                $"Is {year} a leap year? \n - {isLeapYear}");
        }
    }
}
