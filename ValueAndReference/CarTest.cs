using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WritingAClass
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            Car bmw = new Car("Silver", 4, false);

            //act


            //assert
            Assert.AreEqual(bmw.Color, "Silver"); //remember it's case-sensitive

        }

        [TestMethod]
        public void Car_Acceleration_Method()
        {
            //arrange
            Car bmw = new Car("Silver", 4, false);

            //act
            bmw.Accelerate();
        }

        [TestMethod]
        public void FamilyCar_Method()
        {
            //arrange
            Car bmw = new Car("Silver", 4, false);

            //act
            bool carType = bmw.FamilyCar();

            //assertion
            if (carType == true)
                Assert.IsTrue(carType);
            else
                Assert.Fail();
        }
    }
}
