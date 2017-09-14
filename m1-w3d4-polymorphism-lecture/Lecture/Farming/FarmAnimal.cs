using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class FarmAnimal : ISingableItem
    {
        public virtual string Name
        {
            get
            {
                return "";
            }
        }

        public virtual string MakeSoundOnce()
        {
            return "";
        }

        public virtual string MakeSoundTwice()
        {
            return "";
        }
    }
}
