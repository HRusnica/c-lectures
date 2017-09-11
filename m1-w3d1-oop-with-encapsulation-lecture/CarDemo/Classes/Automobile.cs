using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo.Classes
{
    public class Automobile
    {
        //type propfull and press tab 2x
        //to create the class variable & the property
        private int currentSpeed;
        private bool isGoingForward;
        private bool isOn;
        private string name;
        private bool massAirflowFunctioningCorrectly;
        private const int MaxSpeed = 100;

        //Constructor
        public Automobile()
        {
            this.currentSpeed = 0;
            this.isGoingForward = false;
            this.isOn = false;
            this.massAirflowFunctioningCorrectly = true;
        }


        public int CurrentSpeed
        {
            get { return currentSpeed; }
        }
        
        public bool IsGoingForward
        {
            get { return isGoingForward; }
        }
        
        public bool IsOn
        {
            get { return isOn; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public void Start()
        {
            if (this.isOn)
            {
                Console.WriteLine("CRRRCRRCRK");
                return;
            }


            if (this.massAirflowFunctioningCorrectly)
            {
                this.isOn = true;
                Console.WriteLine("VROOM VROOM...");
            }
            else
            {
                Console.WriteLine("PPT PT PT....");
            }
        }


        public void Accelerate(int desiredSpeed)
        {
            if (!this.isOn)
            {
                Console.WriteLine("...car is not on, the engine is flooded");
                return;
            }

            // Accelerate at a rate of 5mph
            while(this.currentSpeed < desiredSpeed)
            {
                if(this.currentSpeed >= MaxSpeed)
                {
                    Console.WriteLine($"Maximum speed reached at {this.currentSpeed}");
                    this.currentSpeed = MaxSpeed;
                    break;
                }


                Console.WriteLine($"Accelerating from {this.currentSpeed}mph to {this.currentSpeed + 5}mph");
                this.currentSpeed += 5;
            }

            Console.WriteLine($"It's smooth sailing from here @ {this.currentSpeed}");

        }

        public void Brake()
        {
            //this.Brake(); //<-- this would be very bad, it would run infinitely
            this.Brake(0); //<-- call our other method already written with the code to brake to a specific speed

            //Console.WriteLine("APPLYING BRAKES!");
            //while (this.currentSpeed > 0)
            //{
            //    Console.WriteLine($"Braking from {this.currentSpeed}mph to {this.currentSpeed - 5}mph");
            //    this.currentSpeed -= 5;
            //}

            //Console.WriteLine($"Current speed: {this.currentSpeed}mph");
        }

        public void Brake(int safeSpeed)
        {
            // Protect against negative speeds
            if(safeSpeed < 0)
            {
                safeSpeed = 0;
            }

            Console.WriteLine("APPLYING BRAKES!");
            while(this.currentSpeed > safeSpeed)
            {
                Console.WriteLine($"Braking from {this.currentSpeed}mph to {this.currentSpeed - 5}mph");
                this.currentSpeed -= 5;
            }

            Console.WriteLine($"Current speed: {this.currentSpeed}mph");
        }



    }
}
