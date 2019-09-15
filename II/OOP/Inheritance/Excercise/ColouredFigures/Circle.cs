using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredFigures
{
    class Circle : ColouredFigure
    {
        public Circle(string colour, double size) : base(colour, size)
        {

        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Size, 2);
        }

        public override string GetName()
        {
            return "Circle:";
        }
    }
}
