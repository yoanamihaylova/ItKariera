using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.WriteLine($"{i}, {j}");
                }
            }
        }
    }
}
