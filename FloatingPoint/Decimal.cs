using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FloatingPoint
{
    [TestClass]
    public class Decimal
    {
        //variables to hold two integer values
        static decimal number1;
        static decimal number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5M; // M for decimals
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5M, sum); // still M for decimals
        }

        [TestMethod]
        public void Test_Substraction()
        {
            decimal difference = number1 - number2;
            Assert.AreEqual(5.5M, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal product = number1 * number2;
            Assert.AreEqual(52.5M, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            decimal quotient = number1 / number2;
            Assert.AreEqual(2.1M, quotient);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            decimal remainder = number1 % number2;
            Assert.AreEqual(0.5M, remainder);
        }
    }
}
