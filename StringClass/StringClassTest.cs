using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringClass
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "Kwasniewski w lesie najbardziej lubi polane";
            Console.WriteLine(str);
            //string halo = new string(" ");
            string substr = str.Substring(20);
            Console.WriteLine(substr);
        }

        [TestMethod]
        public void Joining_Strings_Together()
        {
            char[] chars = { 'h', 'e', 'h', 'e', ' ', 't', 'a', 'a', ',', ' ', 'b', 'e', 'z', ' ', 'k', 'i', 't', 'u' };
            string heheszki = new string(chars);
            Console.WriteLine(heheszki);
        }
    }
}
