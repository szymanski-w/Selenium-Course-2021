using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SectionQuiz
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Calling_The_Name_Test()
        {
            Employee komandos = new Employee(0, "Porucznik", "Borewicz", "18/08/1911", "Sie skacze sie plywa", "Psiarnia", 30.14);
            
            Console.WriteLine(komandos.getName());

            Assert.AreEqual("Porucznik Borewicz", komandos.getName());
        }

        [TestMethod]
        public void Calling_The_Name_To_Sort_Test()
        {
            Employee komandos = new Employee("Porucznik", "Borewicz");

            Console.WriteLine(komandos.getNameToSort());

            Assert.AreEqual("Borewicz, Porucznik", komandos.getNameToSort());
        }
    }
}
