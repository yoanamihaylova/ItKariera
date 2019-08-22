using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1, b2, h;
            b1 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            Console.WriteLine(((b1 + b2) * h) / 2.0);

        }
    }
}
