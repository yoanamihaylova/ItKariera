using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DemoPoint
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override bool Equals(object obj)
        {
            if (!(obj is Point) || obj == null) return false;
            Point point = (Point)obj;
            return (X == point.X && Y == point.Y);
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override int GetHashCode()
        {
            return (X << 16 | X >> 16) ^ Y;
        }

        public int CompareTo(Point other)
        {
            if(X != other.X)
            {
                return X.CompareTo(other.X);
            }
            else
            {
                return Y.CompareTo(other.Y);
            }
        }
    }
}
