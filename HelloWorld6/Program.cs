using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string itemName = "Widget";
            double pricePerKg = 17.36;
            string outputString;

            //format output
            //outputString = String.Format("The current price is {0:C}", pricePerKg);
            outputString = String.Format("{0, 10} {1, 10}", itemName, pricePerKg);

            //output to the user
            Console.WriteLine(String.Format("{0, 10} {1, 10}", "Item Name", "Price"));
            Console.WriteLine(outputString);
        }
    }
}
