using InheritanceLecture.Auctioneering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceLecture.Calculators;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Inheritance
            Console.WriteLine("GAG CALCULATOR");
            GagCalculator gc = new GagCalculator();

            Console.WriteLine("Entering 5");
            gc.EnterNumber(5);
            Console.WriteLine($"The current value is: {gc.Result}");

            Console.WriteLine("Adding 12");
            gc.Add(12);            
            Console.WriteLine($"The current value is: {gc.Result}");


            Console.WriteLine(gc); //WHAT DOES THIS PRINT??
            Console.WriteLine();













            Calculator basicCalc = new Calculator();
            Console.WriteLine($"The current value is: {basicCalc.Result}");

            Console.WriteLine("Entering 5");
            basicCalc.EnterNumber(5);
            Console.WriteLine($"The current value is: {basicCalc.Result}");

            Console.WriteLine("Adding 12");
            basicCalc.Add(12);            
            Console.WriteLine($"The current value is: {basicCalc.Result}");



            Console.WriteLine();
            Console.WriteLine("PROGRAMMER CALC");
            ProgrammingCalculator programmerCalc = new ProgrammingCalculator();
            Console.WriteLine($"The current value is: {programmerCalc.Result}");

            Console.WriteLine("Entering 5");
            programmerCalc.EnterNumber(5);
            Console.WriteLine($"The current value is: {programmerCalc.Result}");

            Console.WriteLine("Adding 12");
            programmerCalc.Add(12);
            Console.WriteLine($"The current value is: {programmerCalc.Result}");

            Console.Write("Showing as binary " );
            Console.WriteLine(programmerCalc.ToBinary());


            Console.WriteLine();
            Console.WriteLine("SCIENTIFIC CALC");
            ScientificCalculator science = new ScientificCalculator();
            Console.WriteLine($"The current value is: {science.Result}");

            Console.WriteLine("Entering 5");
            science.EnterNumber(5);
            Console.WriteLine($"The current value is: {science.Result}");

            Console.WriteLine("Adding 12");
            science.Add(12);
            Console.WriteLine($"The current value is: {science.Result}");

            










            // AUCTIONS

            // Create a new general auction
            //Console.WriteLine("Starting a general auction");
            //Console.WriteLine("-----------------");

            //Auction generalAuction = new Auction();

            //generalAuction.PlaceBid(new Bid("Josh", 1));
            //generalAuction.PlaceBid(new Bid("Fonz", 23));
            //generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            //// The rules of a buyout auction automatically end
            //// when the buyout price is met
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Buyout Auction");
            //Console.WriteLine();
            //Console.WriteLine();

            //BuyoutAuction buyoutAuction = new BuyoutAuction(55);

            //buyoutAuction.PlaceBid(new Bid("Rick Astley", 20));
            //buyoutAuction.PlaceBid(new Bid("Michael Scott", 30));
            //buyoutAuction.PlaceBid(new Bid("Dwight Schrute", 20));
            //buyoutAuction.PlaceBid(new Bid("Ryan Howard", 56));



            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Reserve Auction");
            //Console.WriteLine();
            //Console.WriteLine();

            //ReserveAuction reserveAuction = new ReserveAuction(80);

            //reserveAuction.PlaceBid(new Bid("Ted Mosby", 35));
            //reserveAuction.PlaceBid(new Bid("Marshall Erickson", 55));
            //reserveAuction.PlaceBid(new Bid("Barney Stinson", 80));
            //reserveAuction.PlaceBid(new Bid("Lily Erickson", 60));
            //reserveAuction.PlaceBid(new Bid("Robin Sherbatsky", 85));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
        }
    }
}
