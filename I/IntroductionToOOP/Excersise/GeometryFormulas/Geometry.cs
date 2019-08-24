using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFormulas
{
    public static class Geometry
    {
        public static double SquarePerimeter(double side)
        {
            return 4 * side;
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
        public static double RectanglePerimeter(double a,double b)
        {
            return 2 * (a + b);
        }
        public static double RectangleArea(double a,double b)
        {
            return a * b;
        }
        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
