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

            Console.Write("Would you like to enter a person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            // Declare and instantiate a new dictionary
            Dictionary<string, double> peopleHeights = new Dictionary<string, double>();
            
            while (input == "yes" || input == "y")
            {
                // Get the name
                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();

                // Get their height
                Console.Write("Please enter their height: ");
                double height = double.Parse(Console.ReadLine());

                // Add the student's name and height to the dictionary
                peopleHeights[name] = height;

                Console.WriteLine("Thank you there are now " + peopleHeights.Count + " people recorded.");

                Console.WriteLine();
                Console.Write("Would you like to enter another person (yes/no?) ");
                input = Console.ReadLine().ToLower();
            }

            // Looping through a Dictionary
            foreach (KeyValuePair<string, double> kvp in peopleHeights)
            {
                string name = kvp.Key; //<-- student's name
                double h = kvp.Value; //<-- student's height
                Console.WriteLine(name + " has a height of " + h + " inches tall.");
            }


            
            Console.WriteLine();
            Console.Write("Whose height do you want to retrieve? ");
            string studentName = Console.ReadLine();

            double studentHeight = peopleHeights[studentName]; //<-- gets the value out of the dictionary

            Console.WriteLine(studentName + " is " + studentHeight + " inches tall.");


            Console.WriteLine();
            Console.Write("Who do you want to remove? ");
            string studentToRemove = Console.ReadLine();

            Console.WriteLine("There are now " + peopleHeights.Count + " people recorded.");

            peopleHeights.Remove(studentToRemove);

            

            Console.WriteLine("There are now " + peopleHeights.Count + " people recorded.");

        }
    }
}
