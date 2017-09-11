using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDemo.Classes;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile car = new Automobile();            

            car.Start();
            Console.WriteLine($"The car is started: {car.IsOn}");
            car.Accelerate(20);
            Console.WriteLine();
            Console.WriteLine("It's an open stretch, gun it!");
            car.Accelerate(180);

            // See a cop
            car.Brake(60);
            Console.WriteLine();
            car.Brake();



        }
    }
}
