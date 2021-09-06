using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C# defines the following character escape sequences:

    \' - single quote, needed for character literals
    \" - double quote, needed for string literals
    \\ - backslash
    \0 - Unicode character 0
    \a - Alert(character 7)
    \b - Backspace(character 8)
    \f - Form feed(character 12)
    \n - New line(character 10)
    \r - Carriage return (character 13)
    \t - Horizontal tab(character 9)
    \v - Vertical quote(character 11)
    \uxxxx - Unicode escape sequence for character with hex value xxxx
    \xn[n][n][n] - Unicode escape sequence for character with hex value nnnn(variable length version of \uxxxx)
    \Uxxxxxxxx - Unicode escape sequence for character with hex value xxxxxxxx(for generating surrogates)
    Of these, \a, \f, \v, \x and \U are rarely used in my experience.

[Author: Jon Skeet]*/

namespace HelloWorld7
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileDir = "C:\\my Documents\\good shit\\bad shit"; //escape seqence
            string fileDir = @"C:\my Documents\good shit\bad shit"; //verbatim string
            Console.WriteLine(fileDir);
        }
    }
}
