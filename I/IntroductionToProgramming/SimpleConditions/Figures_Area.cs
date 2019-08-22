using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            type = Console.ReadLine();
            if (type == "square")
            {
                double a;
                a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (type == "circle")
            {
                double r;
                r = double.Parse(Console.ReadLine());
                Console.WriteLine(r * r * Math.PI);
            }
            else if (type == "triangle")
            {
                double a, h;
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                Console.WriteLine((a * h) / 2);
            }
            else if (type == "rectangle")
            {
                double a, b;
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);

            }
        }
    }
}
