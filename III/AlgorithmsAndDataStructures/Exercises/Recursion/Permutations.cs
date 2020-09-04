using System;

namespace Permutation
{
    class Permutations
    {
        static bool[] used;
        static int[] perm;
        static int[] elements;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }
            used = new bool[n];
            perm = new int[n];
            Gen(0);
        }

        private static void Gen(int index)
        {
            if (perm.Length == index) Console.WriteLine(string.Join(" ",perm));
            else 
                for (int i = 0; i < elements.Length; i++)
                {
                    if(!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Gen(index + 1);
                        used[i] = false;
                       // perm[index] = 0;
                    }
                }
        }
    }
}
