using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCompare
{
    class Point : IComparable<Point>
    {
        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int CompareTo(Point otherPoint)
        {
            if (this.X != otherPoint.X) return this.X - otherPoint.X;
            if (this.Y != otherPoint.Y) return this.Y - otherPoint.Y;
            return 0;
        }
    }
}
