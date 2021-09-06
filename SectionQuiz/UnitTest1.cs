using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SectionQuiz
{
    [TestClass]
    public class UnitTest1
    {
        static double temp_C;
        static double temp_F;

        [TestMethod]
        public void Convert_F_To_C()
        {
            temp_F = 104; // insert the temperature in Fahrenheits
            temp_C = (temp_F - 32) / 1.8;
            Console.WriteLine("{0} *F is equal to {1} *C", temp_F, temp_C);
            Assert.AreEqual(40, temp_C, 0.001); // 0.001 tolerance
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            temp_C = 40; // insert the temperature in Celsius
            temp_F = temp_C * 1.8 + 32;
            Console.WriteLine($"{temp_C} *C is equal to {temp_F} *F"); // different approach
            Assert.AreEqual(104, temp_F, 0.001);
        }
    }
}
