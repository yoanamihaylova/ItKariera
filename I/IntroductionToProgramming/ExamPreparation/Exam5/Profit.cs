using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double M,ex;
            N = int.Parse(Console.ReadLine());
            M = double.Parse(Console.ReadLine());
            ex = double.Parse(Console.ReadLine());
            double Mp = N * M;
            double Y = Mp * 12 + Mp * 2.5;
            double P = (25.0 /100) * Y;
            double cP = (Y-P) * ex;
            double A = cP / 365;
            Console.WriteLine("{0:f2}",A);
        }
    }
}
