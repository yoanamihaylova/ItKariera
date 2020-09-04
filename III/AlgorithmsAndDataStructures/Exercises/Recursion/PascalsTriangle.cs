using System;

namespace PascalsTriangle
{
    class PascalsTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(Binom(n,i) + " ");
            }

        }
        private static int Binom (int n, int k)
        {
            if (n == k || k == 0) return 1;
            return Binom(n - 1, k) + Binom(n - 1, k - 1);
        }
    }
}
