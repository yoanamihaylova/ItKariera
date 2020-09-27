using System;

namespace DemoPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine(p1.GetHashCode());
        }
    }
}
