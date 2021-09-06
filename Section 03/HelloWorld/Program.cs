using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        int accessibleInTheProgramClass;
        //you should create variables only with the accessibility level you need
        static void Main(string[] args)
        {
            int accessibleInTheMainMethod = 0;
            char holdsALetter = 'a';
            double amount;

            amount = 2.5;
        }
    }
}
