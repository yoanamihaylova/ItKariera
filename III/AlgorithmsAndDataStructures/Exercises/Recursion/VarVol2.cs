using System;
using System.Linq;

namespace ConsoleApp3
{
    class VarVol2
    {
        static bool[] used;
        static int[] var;
        static int k;
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            used = new bool[n];
            var = new int[n];
            Gen(0);
        }

        private static void Gen(int index)
        {
            if (index == k) Console.WriteLine(string.Join(" ", var.Take(k)));
            else
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        var[index] = i+1;
                        Gen(index + 1);
                        used[i] = false;
                    }
                }
        }
    }
}
