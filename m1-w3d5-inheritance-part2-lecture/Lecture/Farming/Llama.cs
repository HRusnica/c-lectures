using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Llama : FarmAnimal
    {
        public override string Name
        {
            get
            {
                return "LLAMA";
            }
        }

        public override string MakeSoundOnce()
        {
            return "BLEEEH";
        }

        public override string MakeSoundTwice()
        {
            return "BLEEEH BLEEEH";
        }
    }
}
