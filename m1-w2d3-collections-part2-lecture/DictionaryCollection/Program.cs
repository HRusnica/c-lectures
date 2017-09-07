using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person / Height Database");
            Console.WriteLine();

            Console.Write("Would you like to enter another person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            while (input == "yes" || input == "y")
            {
                

                Console.Write("Would you like to enter another person (yes/no? ");
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.WriteLine(".... printing ...");
        }
    }
}
