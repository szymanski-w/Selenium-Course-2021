using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string userFirstName;
            string age;

            //ask the user their name
            Console.WriteLine("Jak masz na imie?");
            userFirstName = Console.ReadLine();

            //ask the user their age
            Console.WriteLine("Ile masz lat?");
            age = Console.ReadLine();


            //contatenation
            string response = "Masz na imie " + userFirstName + " i masz " + age + " lat.";

            //response
            Console.WriteLine(response);
        }
    }
}
