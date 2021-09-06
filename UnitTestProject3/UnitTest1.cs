using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    [TestCategory("Part4")]
    public class Test4
    {
        private int a;
        public TestContext Test4Context { get; set; }
        private static TestContext _testContext;

        [TestInitialize]
        public void RunBeforeEveryTestMethod()
        {
            a = 1;
        }

        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single method in a class");
        }

        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodStarted(TestContext testContext)
        {
            testContext = _testContext;
            Trace.Write("I will run one time before all the tests in the class started");
        }

        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.Write("I will run one time after all the tests in the class finished");
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
