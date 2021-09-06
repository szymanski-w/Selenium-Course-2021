using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwitchStatement
{
    [TestClass]
    public class StateAbbreviation
    {
        [TestMethod]
        public void State_Abbrev_Test()
        {
            string stateAbbrev = "GA";
            string stateName = "";

            switch(stateAbbrev)
            {
                case "AL":
                    stateName = "Alabama";
                    break;
                case "FL":
                    stateName = "Florida";
                    break;
                case "GA":
                    stateName = "Georgia";
                    break;
                case "IL":
                    stateName = "Illiois";
                    break;
                case "KY":
                    stateName = "Kentucky";
                    break;
                case "MI":
                    stateName = "Michigan";
                    break;
                default:
                    stateName = "No match";
                    break;
            }

            Assert.AreEqual("Georgia", stateName);
        }
    }
}
