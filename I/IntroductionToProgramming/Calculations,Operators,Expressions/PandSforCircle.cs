using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_and_S_for_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            r = double.Parse(Console.ReadLine());
            Console.Write("{0:f2}", Math.PI * r * r);
            Console.WriteLine(" {0:f2}", Math.PI * 2 * r);

        }
    }
}
