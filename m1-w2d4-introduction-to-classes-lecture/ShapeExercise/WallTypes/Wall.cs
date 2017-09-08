using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise.WallTypes
{
    public class Wall
    {
        //public int Height { get; set; } <-- don't try this at home

        private int height;
        private int width;
        private string color;


        public Wall(int height, int width)
        {
            this.height = height;
            this.width = width;
        }


        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Height
        {
            get { return this.height; }
        }

        public int Width
        {
            get { return this.width; }
        }

        public int GetArea()
        {
            return this.width * this.height;
        }


    }
}
