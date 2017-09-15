using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        public Horse(bool isAwake) : base(isAwake)
        {

        }

        public override string Name
        {
            get { return "HORSE"; }
        }

        protected override string MakeAwakeNoiseOnce()
        {
            return "NEIGH";
        }

        protected override string MakeAwakeNoiseTwice()
        {
            return "NEIGH NEIGH";
        }

        


    }
}
