using System;
using System.Linq;

namespace SumOfArray
{
    class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Sum(arr,0));
        }

        private static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1) return arr[index];
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
