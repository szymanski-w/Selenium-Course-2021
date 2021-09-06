using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForLoops
{
    [TestClass]
    public class StrangeForLoops
    {
        [TestMethod]
        public void Strange_For_Loops()
        {
            //two variable initialized
            for (int counter = 0, val1 = 10; counter < val1; counter++)
            {
            }

            //initialization not included as part of for statement
            int count2 = 0;
            for (; count2 < 100; count2 += 10)
            {
            }

            for (int j = 0; ; j++)
            {

            }

            //use of floating point variables is permissible
            for (double d = 15.0; d < 20.0; d += 0.5)
            {
            }
        }
    }
}
