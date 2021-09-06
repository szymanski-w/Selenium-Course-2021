using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueAndReference
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test_Employee_ID_Test()
        {
            Employee cieciu = new Employee(123);

            cieciu.JobTitle = "Staff";

            string jobLocation = cieciu.JobLocation();
            Assert.AreEqual("Pcim Dolny", jobLocation);
        }

        [TestMethod]
        public void To_String_Test()
        {
            Employee rychu = new Employee("Ryszard", 92, "Manager");
            Console.WriteLine(rychu);
        }
    }
}
