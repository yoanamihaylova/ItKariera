using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, M;
            int n, m;
            N = double.Parse(Console.ReadLine());
            M = double.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine((N*n+M*m)/1.94);
        }
    }
}
