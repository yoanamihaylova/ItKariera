using System;
using System.Linq;

namespace ConsoleApp2
{
    class CombVol2
    {
        static int[] combs;
        static int k;
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            combs = new int[n];
            Gen(0, 0);
        }

        private static void Gen(int index, int start)
        {
            if (index == k) Console.WriteLine(string.Join(" ", combs.Take(k)));
            for (int i = start; i < n; i++)
            {
                combs[index] = i+1;
                Gen(index + 1, i + 1);
                // var[index] = 0;
            }
        }
    }
}
