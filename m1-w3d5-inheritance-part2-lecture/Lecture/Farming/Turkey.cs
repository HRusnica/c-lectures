using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Turkey : FarmAnimal
    {
        public override string Name
        {
            get
            {
                return "TURKEY";
            }
        }

        public override string MakeSoundOnce()
        {
            return "GOBBLE"; ;
        }

        public override string MakeSoundTwice()
        {
            return "GOBBLE GOBBLE";
        }
    }
}
