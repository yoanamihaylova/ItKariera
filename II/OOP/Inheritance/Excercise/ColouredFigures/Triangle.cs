using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredFigures
{
    class Triangle : ColouredFigure
    {
        public override double GetArea()
        {
          return Size * Size * Math.Sqrt(3) / 4;
        }

        public override string GetName()
        {
            return "Triangle:";
        }
        public Triangle(string colour,double size) : base (colour,size)
        {

        }

    }
}
