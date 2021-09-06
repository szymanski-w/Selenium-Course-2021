using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhileLoops
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1; 
            while(number < 11)
            {
                //the code that will continue to execute while the statement condition is true
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;
            Console.WriteLine("oryginal value is " + number + "\n");
            //number = 1
            Console.WriteLine("post increment value is: " + number++); //number = 1
            //number = 2
            Console.WriteLine("pre increment value is: " + ++number); //number = 3
            //number = 3
            Console.WriteLine("post decrement value is: " + number--); //number = 3
            //number = 2
            Console.WriteLine("pre decrement value is: " + --number); // number = 1
            //number = 1
        }

        //[TestMethod]
        //public void Test_Sentinel_Controlled_Loop()
        //{
        //    string inValue = "";
        //    while (inValue != "-99")
        //    {
        //        Console.Write("\nEnter value (-99 to exit): ");
        //        inValue = Console.ReadLine();
        //    }
        //    Console.ReadKey();
        //}

        [TestMethod]
        public void Test_Nested_Loops()
        {
            int number1 = 1;
            int number2 = 1;
            while (number1 <= 5)
            {
                while (number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }
                number1++;
            }
        }
    }
}
