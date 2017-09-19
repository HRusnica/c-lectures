using Lecture.Aids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string path = @"C:\Projects\DotNet-Cohort-6\c-lectures\m1-w4d2-file-io-part1-lecture\Lecture\numbers.txt";
                using (StreamReader sr = new StreamReader(path))
                {

                    int sum = 0;

                    while (!sr.EndOfStream)
                    {
                        string nextLine = sr.ReadLine();

                        sum += int.Parse(nextLine);
                    }

                    Console.WriteLine("The sum is " + sum);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
