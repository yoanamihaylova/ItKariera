using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, h;
            a = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(a * h / 2.0, 2));

        }
    }
}
