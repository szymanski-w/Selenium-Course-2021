using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FloatingPoint
{
    [TestClass]
    public class Double
    {
        //variables to hold two integer values
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5, sum);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(5.5, difference);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double product = number1 * number2;
            Assert.AreEqual(52.5, product);
        }

        [TestMethod]
        public void Test_Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(2.1, quotient);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            double remainder = number1 % number2;
            Assert.AreEqual(0.5, remainder);
        }
    }
}
