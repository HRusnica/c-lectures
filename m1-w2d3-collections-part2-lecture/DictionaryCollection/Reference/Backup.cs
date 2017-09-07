using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection.Reference
{
    class Backup
    {
        public static void DoBackup()
        {
            Console.WriteLine("Welcome to the Person / Height Database");
            Console.WriteLine();

            Console.Write("Would you like to enter person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            List<string> names = new List<string>(); //<-- student names
            List<double> heights = new List<double>(); //<-- student heights

            while (input == "yes" || input == "y")
            {
                // Get the name
                Console.Write("Please enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);

                // Get their height
                Console.Write("Please enter their height: ");
                double height;
                string inputValue = Console.ReadLine();
                if (double.TryParse(inputValue, out height)) //<-- they typed in a valid height
                {
                    heights.Add(height);
                }
                else
                {
                    heights.Add(-1);
                }


                Console.WriteLine();
                Console.Write("Would you like to enter another person (yes/no?) ");
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.Write("Whose height do you want to retrieve? ");
            string studentName = Console.ReadLine();

            int indexOfStudent = -1; // names.IndexOf(studentName);
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == studentName)
                {
                    indexOfStudent = i;
                    break;
                }
            }
            Console.WriteLine(names[indexOfStudent] + " is " + heights[indexOfStudent] + " inches tall.");


            //Mandy is 65 inches tall
            // Teddi is 62 inches tall
            // Lindsay is 71 inches tall
            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (heights[i] == -1)
            //    {
            //        Console.WriteLine(names[i] + " - height not available.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(names[i] + " is " + heights[i] + " inches tall.");
            //    }
            //}
        }
    }
}
