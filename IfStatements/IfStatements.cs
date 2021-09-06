using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IfStatements
{
    [TestClass]
    public class IfStatements
    {
        //variables to hold two integer values
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Number1_Is_Equal_To_Number2()
        {
            if (number1 == number2)
            {
                //this code executes if statemant is true

                Assert.IsTrue(number1 == number2);
            }
            else
            {
                //this code executes if statemant is false

                //Assert.IsFalse(number1 == number2);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_To_Number2()
        {
            if (number1 != number2)
                Assert.IsTrue(number1 != number2); // if only one line of code to execute {} are not necessary
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Greater_Than_Number2()
        {
            if (number1 > number2)
                Assert.IsTrue(number1 > number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void Number1_Greater_Than_Equal_To_Number2()
        {
            if (number1 >= number2)
                Assert.IsTrue(number1 >= number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Number1_Less_Than_Number2()
        {
            if (number1 < number2)
                Assert.IsTrue(number1 < number2);
            else
                Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Number1_Less_Than_Or_Equal_To_Number2()
        {
            if (number1 <= number2)
                Assert.IsTrue(number1 <= number2);
            else
                Assert.Fail();
        }
    }
}
