using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Calculators
{
    public class GagCalculator : Calculator
    {
        public override double Add(double addend)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100000);
            return base.Add(randomNumber);
        }

        public override string ToString()
        {
            return "GAG CALCULATOR CURRENT VALUE IS " + this.Result;
        }

    }
}
