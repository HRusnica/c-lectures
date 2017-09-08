using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Add a using statement
using ShapeExercise.WallTypes;


namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wall northWall = new Wall(10, 14);
            //Wall southWall = new Wall(10, 8);

            //northWall.Color = "Blue";
            //northWall.Color = "Yellow";


            //Console.WriteLine($"The north wall is {northWall.Height} x {northWall.Width} - area {northWall.GetArea()}");
            //Console.WriteLine($"The south wall is {southWall.Height} x {southWall.Width} - area {southWall.GetArea()}");


            List<Wall> wallsToPaint = new List<Wall>();

            while (true)
            {
                Console.WriteLine("[1] Add a wall");
                Console.WriteLine("[2] Calculate paint required (and Exit)");
                Console.Write("Please choose >>> ");
                string userChoice = Console.ReadLine();

                Console.WriteLine();

                if (userChoice == "1")
                {
                    Console.Write("Enter wall height >>> ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Enter wall width >>> ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Enter wall color >>> ");
                    string color = Console.ReadLine();

                    Wall w = new Wall(height, width);
                    w.Color = color;

                    wallsToPaint.Add(w);


                    Console.WriteLine($"Added {w.Height}x{w.Width} ({w.Color}) wall :) {w.GetArea()} square feet");
                }
                else if (userChoice == "2")
                {
                    int totalArea = 0;

                    for (int i = 0; i < wallsToPaint.Count; i++)
                    {
                        int wallArea = wallsToPaint[i].GetArea();
                        totalArea = totalArea + wallArea;
                        Console.WriteLine($"Wall {i + 1} ({wallsToPaint[i].Color}): {wallsToPaint[i].Height}x{wallsToPaint[i].Width} - {wallArea} square feet");
                    }

                    Console.WriteLine("===============================");
                    Console.WriteLine("Total Area: " + totalArea + " square feet");

                    // 1 gallon of paint covers 400 square feet
                    double gallonsRequired = (double)totalArea / 400;
                    Console.WriteLine("Paint Required: " + gallonsRequired + " gallons");

                    return;
                }
            }








            // WHERE WE CAME FROM
            //List<int> heights = new List<int>();
            //List<int> widths = new List<int>();
            //List<string> colors = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("[1] Add a wall");
            //    Console.WriteLine("[2] Calculate paint required (and Exit)");
            //    Console.Write("Please choose >>> ");
            //    string userChoice = Console.ReadLine();

            //    Console.WriteLine();

            //    if(userChoice == "1")
            //    {
            //        Console.Write("Enter wall height >>> ");
            //        int height = int.Parse(Console.ReadLine());
            //        Console.Write("Enter wall width >>> ");
            //        int width = int.Parse(Console.ReadLine());
            //        Console.Write("Enter wall color >>> ");
            //        string color = Console.ReadLine();

            //        heights.Add(height); //<-- add the new height
            //        widths.Add(width);  //<-- add the new width
            //        colors.Add(color);


            //        int area = height * width;

            //        Console.WriteLine("Added " + height + "x" + width + " wall - " + area + " square feet");
            //    }
            //    else if (userChoice == "2")
            //    {
            //        int totalArea = 0;

            //        for(int i = 0; i < heights.Count; i++)
            //        {
            //            int wallArea = heights[i] * widths[i];
            //            totalArea = totalArea + wallArea;
            //            Console.WriteLine($"Wall {i + 1} ({colors[i]}): {heights[i]}x{widths[i]} - {wallArea} square feet");
            //        }

            //        Console.WriteLine("===============================");
            //        Console.WriteLine("Total Area: " + totalArea + " square feet");

            //        // 1 gallon of paint covers 400 square feet
            //        double gallonsRequired = (double)totalArea / 400;
            //        Console.WriteLine("Paint Required: " + gallonsRequired + " gallons");

            //        return;
            //    }
            //}

        }
    }
}
