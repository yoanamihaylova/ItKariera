using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, O;
            double W, L;
            N = int.Parse(Console.ReadLine());
            W = double.Parse(Console.ReadLine());
            L = double.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            O = int.Parse(Console.ReadLine());
            N = N * N;
            W = W * L;
            M = M * O;
            Console.WriteLine("{0}",(N-M)/W);
            Console.WriteLine("{0}",((N - M) / W)*0.2);
        }
    }
}
