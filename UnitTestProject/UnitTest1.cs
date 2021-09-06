using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("login feature")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("positive")]
        [Description("these are demo unit tests")] //only valid on test >methods<
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(3, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var a = 1;
            Assert.AreNotEqual(2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod4()
        {
            var a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
}
