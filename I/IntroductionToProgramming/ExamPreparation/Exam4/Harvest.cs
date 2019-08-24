using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, br;
            double y;
            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            br = int.Parse(Console.ReadLine());
            double all = x * y;
            double w =( (40.0 / 100) * all)/2.5;
            if (w>= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(w));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(w-z), Math.Ceiling((w - z) / br));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z-w));
            }
        }
    }
}
