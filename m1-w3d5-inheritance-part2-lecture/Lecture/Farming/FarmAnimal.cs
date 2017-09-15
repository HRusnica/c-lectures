using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public abstract class FarmAnimal : ISingableItem
    {
        private bool isAwake = true;

        // Constructor
        public FarmAnimal(bool isAwake)
        {
            this.isAwake = isAwake;
        }


        public abstract string Name { get; } //<-- forces the subclass to implement this property

        public string MakeSoundOnce()
        {
            if (this.isAwake)
            {
                return this.MakeAwakeNoiseOnce();
            }
            else
            {
                return "ZZZZ";
            }
        }

        public string MakeSoundTwice()
        {
            if (this.isAwake)
            {
                return this.MakeAwakeNoiseTwice();
            }
            else
            {
                return "ZZZZ ZZZZ";
            }
        }


        protected abstract string MakeAwakeNoiseOnce();
        protected abstract string MakeAwakeNoiseTwice();


    }
}
