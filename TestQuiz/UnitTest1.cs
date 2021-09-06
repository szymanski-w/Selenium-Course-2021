using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestQuiz
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Assert.Fail("This will always fail");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            int a = 10;
            Assert.AreEqual(21, a + a);
        }
    }
}
