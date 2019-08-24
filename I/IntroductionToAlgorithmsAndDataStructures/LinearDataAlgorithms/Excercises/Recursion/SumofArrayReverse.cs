using System;
using System.Linq;

namespace SumOfArray
{
    class SumofArrayReverse
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Sum(arr, arr.Length-1));
        }

        private static int Sum(int[] arr, int index)
        {
            if (index == 0) return arr[0];
            return arr[index] + Sum(arr, index - 1);
        }
    }
}
