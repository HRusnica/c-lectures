using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Owl : FarmAnimal
    {
        public Owl(bool isAwake) : base(isAwake)
        {
        }

        public override string Name
        {
            get { return "OWL"; }
        }

        protected override string MakeAwakeNoiseOnce()
        {
            return "HOO";
        }

        protected override string MakeAwakeNoiseTwice()
        {
            return "HOO HOO";
        }
    }
}
