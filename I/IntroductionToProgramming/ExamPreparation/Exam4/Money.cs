using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            double c, k;
            b = int.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            k = double.Parse(Console.ReadLine());
            Console.WriteLine(((b * 1168 + c * 0.15 * 1.76) / 1.95)-((k / 100)*(b*1168+c*0.15*1.76)/1.95));
        }
    }
}
