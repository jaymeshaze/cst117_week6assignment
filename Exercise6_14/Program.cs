using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program that changes every 'p' to a 'q' in a String entered by the user.

namespace Exercise6_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            String userString = Console.ReadLine();

            Console.WriteLine(userString);

            String newString = userString.Replace("p", "q");

            Console.WriteLine(newString);
        }
    }
}
