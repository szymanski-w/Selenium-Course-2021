using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoWhileLoops
{
    [TestClass]
    public class DoWhile
    {
        [TestMethod]
        public void Do_While_Test()
        {
            int sum = 0;
            int number = 1;
            do
            {
                sum += number;
                number++;
            }
            while (number <= 10);

            // 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55
            Assert.AreEqual(55, sum);
        }
    }
}
