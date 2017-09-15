using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Squirrel : FarmAnimal
    {
        public override string Name
        {
            get
            {
                return "SQUIRREL";
            }
        }

        public override string MakeSoundOnce()
        {
            return "PUFF";
        }

        public override string MakeSoundTwice()
        {
            return "PUFF PUFF";
        }
    }
}
