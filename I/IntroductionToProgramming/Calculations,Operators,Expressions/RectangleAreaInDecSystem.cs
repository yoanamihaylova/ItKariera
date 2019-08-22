using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area_in_DecSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1;
            double x2, y2;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine((((Math.Abs(x1 - x2))) * (Math.Abs(y1 - y2))));
            Console.WriteLine(2 * ((Math.Abs(x1 - x2)) + (Math.Abs(y1 - y2))));
        }

    }
}

