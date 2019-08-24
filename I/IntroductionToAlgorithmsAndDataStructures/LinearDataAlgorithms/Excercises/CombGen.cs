using System;
using System.Linq;

namespace CombGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            GenComb(vector, 0, 1);
        }
        static int k;
        private static void GenComb(int[] vector, int index, int border)
        {
            if (index == k) Console.WriteLine(string.Join(string.Empty, vector.Take(k)));
            else
            {
                for (int i = border; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    GenComb(vector, index + 1,i+1);
                }
            }
        }
    }
}
