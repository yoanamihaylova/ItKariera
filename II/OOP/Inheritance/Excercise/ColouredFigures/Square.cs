using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredFigures
{
    class Square : ColouredFigure
    {
        public Square(string colour, double size) : base(colour, size)
        {
        }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override string GetName()
        {
            return "Square:";
        }
    }
}
