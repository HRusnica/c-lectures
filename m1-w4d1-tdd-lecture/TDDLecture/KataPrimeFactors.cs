using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLecture
{
    //Factorize a positive integer number into its prime factors.

    //Use the TDD approach to write tests that call a single method `Factorize()`. 
    //Given a positive integer input n, return its prime factors.

    //1 is always omitted from the result set.
    //2 -> returns[2]
    //3 -> returns[3]
    //4 -> returns[2, 2]
    //6 -> returns[2, 3]
    //7 -> returns[7]
    //8 -> returns[2, 2, 2]
    //9 -> returns[3, 3]
    //10 -> returns[2, 5]
    //24 -> returns [2, 2, 2, 3]
    public class KataPrimeFactors
    {
        public int[] Factorize(int number)
        {
            List<int> output = new List<int>();

            for (int divisor = 2; divisor < number; divisor++)
            {
                while (number % divisor == 0)
                {
                    output.Add(divisor); //add the divisor as a prime factor
                    number = number / divisor;
                }
            }

            if (number > 1)
            {
                output.Add(number);
            }


            return output.ToArray();
        }
    }
}
