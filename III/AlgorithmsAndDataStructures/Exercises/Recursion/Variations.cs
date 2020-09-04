using System;
using System.Linq;

namespace Variations
{
    class Variations
    {
        static bool[] used;
        static int[] var;
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
            used = new bool[n];
            var = new int[n];
            Gen(0);
        }

        private static void Gen(int index)
        {
            if (index == k) Console.WriteLine(string.Join(" ", var.Take(k)));
            else
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        var[index] = elements[i];
                        Gen(index + 1);
                        used[i] = false;
                        // var[index] = 0;
                    }
                }
        }
    }
}
