using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a;

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreNotEqual(2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod4()
        {
            Assert.AreNotEqual(1, a);
        }
    }
}
