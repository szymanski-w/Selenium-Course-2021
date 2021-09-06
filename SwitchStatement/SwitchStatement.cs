using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwitchStatement
{
    [TestClass]
    public class SwitchStatement
    {
        [TestMethod]
        public void Switch_Statement_Test()
        {
            int weekDay = 4;
            string testDay = "";
            switch (weekDay)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay = "Friday";
                    break;
                case 6:
                    testDay = "Saturday";
                    break;
                case 7:
                    testDay = "Sunday";
                    break;
                default:
                    testDay = "ni ma tak";
                    break;
            }
            Assert.AreEqual("Thursday", testDay);
        }
    }
}
