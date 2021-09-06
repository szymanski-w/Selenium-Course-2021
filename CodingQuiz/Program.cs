using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int o = 0;
            while(o < 3)
            {
                i = 10;
                while (i > 5)
                {
                    Console.Write("Outer = {0}\tInner = {1}\n", o, i);
                    i--;
                }
                o++;
            }
            Console.ReadLine();
        }
    }
}
