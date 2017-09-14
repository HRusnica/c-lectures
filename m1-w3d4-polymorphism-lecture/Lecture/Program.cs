using Lecture.Farming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chicken chicken = new Chicken();
            //Cow cow = new Cow();
            //Llama llama = new Llama();
            List<ISingableItem> oldMacDonaldsArmy = new List<ISingableItem>();

            oldMacDonaldsArmy.Add(new FarmAnimal());
            oldMacDonaldsArmy.Add(new Chicken());
            oldMacDonaldsArmy.Add(new Cow());
            oldMacDonaldsArmy.Add(new Llama());
            oldMacDonaldsArmy.Add(new Turkey());
            oldMacDonaldsArmy.Add(new Chicken());
            oldMacDonaldsArmy.Add(new Squirrel());
            oldMacDonaldsArmy.Add(new Tractor());
            oldMacDonaldsArmy.Add(new FarmersWife());


            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");


            foreach (ISingableItem singableItem in oldMacDonaldsArmy)
            {
                Console.WriteLine("And on his farm there was a " + singableItem.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + singableItem.MakeSoundTwice() + " here and a " + singableItem.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + singableItem.MakeSoundOnce() + ", there a " + singableItem.MakeSoundOnce() + " everywhere a " + singableItem.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }


            //
            // OLD MACDONALD
            //
            
            //Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");
            
            //Console.WriteLine("And on his farm there was a " + chicken.Name + " ee ay ee ay oh");
            //Console.WriteLine("With a " + chicken.MakeSoundTwice() + " here and a " + chicken.MakeSoundTwice() + " there");
            //Console.WriteLine("Here a " + chicken.MakeSoundOnce() + ", there a " + chicken.MakeSoundOnce() + " everywhere a " + chicken.MakeSoundTwice());
            //Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            //Console.WriteLine();

            //Console.WriteLine("And on his farm there was a " + cow.Name + " ee ay ee ay oh");
            //Console.WriteLine("With a " + cow.MakeSoundTwice() + " here and a " + cow.MakeSoundTwice() + " there");
            //Console.WriteLine("Here a " + cow.MakeSoundOnce() + ", there a " + cow.MakeSoundOnce() + " everywhere a " + cow.MakeSoundTwice());
            //Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            //Console.WriteLine();

            //Console.WriteLine("And on his farm there was a " + llama.Name + " ee ay ee ay oh");
            //Console.WriteLine("With a " + llama.MakeSoundTwice() + " here and a " + llama.MakeSoundTwice() + " there");
            //Console.WriteLine("Here a " + llama.MakeSoundOnce() + ", there a " + llama.MakeSoundOnce() + " everywhere a " + llama.MakeSoundTwice());
            //Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            //Console.WriteLine();


        }
    }
}
