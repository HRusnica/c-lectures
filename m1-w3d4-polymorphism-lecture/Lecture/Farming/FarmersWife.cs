using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class FarmersWife : ISingableItem
    {
        public string Name
        {
            get
            {
                return "DOROTHY";
            }
        }

        public string MakeSoundOnce()
        {
            return "TIME TO FEED THE CHICKENS";
        }

        public string MakeSoundTwice()
        {
            return "TIME TO FEED THE CHICKENS TIME TO FEED THE CHICKENS";
        }
    }
}
