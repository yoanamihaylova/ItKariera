using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredFigures
{
    abstract class ColouredFigure
    {
        public string Colour { get; set; }
        public double Size { get; set; }
        protected ColouredFigure(string colour, double size)
        {
            this.Colour = colour;
            this.Size = size;
        }
        public void Show()
        {
            Console.WriteLine($"Color: {this.Colour}");
            Console.WriteLine($"Size: {this.Size}");
        }
        public abstract string GetName();
        public abstract double GetArea();



    }
}
