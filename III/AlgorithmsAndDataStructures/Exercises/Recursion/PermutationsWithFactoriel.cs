using System;
using System.Numerics;

namespace PermutationsWithFactoriel
{
    class PermutationsWithFactoriel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine( Fact(n));
        }
        static BigInteger Fact(int n)
        {
            if (n == 1) return 1;
            return n * Fact(n - 1);
        }
    }
}
