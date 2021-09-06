using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_Exam
{
    [TestClass]
    public class TripTest
    {
        Trip dw_dkl_ct = new Trip("Torun", 570, 253, 44.5);

        //[TestInitialize]
        //public void Object_Creation()
        //{
        //    Trip dw_dkl_ct = new Trip("Torun", 570, 253, 44.5);
        //}

        [TestMethod]
        public void To_String_Test()
        {
            Console.WriteLine(dw_dkl_ct);
        }

        [TestMethod]
        public void Consumption_Method_Test()
        {
            Assert.AreEqual((44.5 * 100) / 570, dw_dkl_ct.Consumption());
        }

        [TestMethod]
        public void CostPerKm_Method_Test()
        {
            Assert.AreEqual(253.0 / 570.0, dw_dkl_ct.CostPerKm());
        }
    }
}
