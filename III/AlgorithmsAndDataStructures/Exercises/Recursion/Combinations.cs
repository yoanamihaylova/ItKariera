using System;
using System.Linq;

namespace Combinations
{
    class Combinations
    {

        static int[] combs;
        static int[] elements;
        static int k;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }
            combs = new int[n];
            Gen(0, 0);
        }

        private static void Gen(int index, int start)
        {
            if (index == k) Console.WriteLine(string.Join(" ", combs.Take(k)));
            for (int i = start; i < elements.Length; i++)
            {
                combs[index] = elements[i];
                Gen(index + 1, i + 1);
                // var[index] = 0;
            }
        }
    }
}
