using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_StringExamplesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allows the user to enter a string, then outputs the string back to them
            Console.WriteLine("Please enter a string.");
            string s = Console.ReadLine();
            Console.WriteLine($"You entered: {s}");

            Console.ReadKey();
        }
    }
}
