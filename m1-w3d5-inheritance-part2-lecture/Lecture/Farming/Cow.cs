using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Cow : FarmAnimal
    {
        public override string Name
        {
            get
            {
                return "COW";
            }
        }

        public override string MakeSoundOnce()
        {
            return "MOO";
        }

        public override string MakeSoundTwice()
        {
            return "MOO MOO";
        }
    }
}
