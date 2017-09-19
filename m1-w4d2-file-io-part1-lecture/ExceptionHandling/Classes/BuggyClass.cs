using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Classes
{
    public class BuggyClass
    {

        public int DoSomethingBuggy()
        {
            int x = 5;
            return DoSomethingBuggyTwoLayersDown();            
        }

        public int DoSomethingBuggyTwoLayersDown()
        {
            int somethingUseless = 2;
            return DoSomethingBuggyThreeLayersDown();
        }

        public int DoSomethingBuggyThreeLayersDown()
        {
            int[] array = new int[3] { 0, 1, 10 };
            return array[2];
        }

    }
}
