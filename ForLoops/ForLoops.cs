using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForLoops
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void For_Loop_Test()
        {
            //for(iniitialize; test; update)
            for (int o = 0; o < 3; o++)
            {
                for (int i = 10; i > 5; i--)
                {
                    Console.WriteLine($"Outer = {o}\tInner = {i}");
                }
            }
        }
    }
}
