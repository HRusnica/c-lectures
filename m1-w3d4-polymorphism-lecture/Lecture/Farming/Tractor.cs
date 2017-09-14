using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Tractor : ISingableItem
    {
        public string Name
        {
            get { return "TRACTOR"; }
        }

        public string MakeSoundOnce()
        {
            return "VROOM";
        }

        public string MakeSoundTwice()
        {
            return "VROOM VROOM";
        }
    }
}
