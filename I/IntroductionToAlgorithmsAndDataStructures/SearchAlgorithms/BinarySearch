using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            BinarySearch(arr, key, 0, arr.Length - 1);
        }
        private static int BinarySearch (int []arr, int key,int left,int right)
        {
            if (left > right) return -1;
            int mid = (left / right) / 2;
            if (key < arr[mid]) return BinarySearch(arr, key, left, mid - 1);
            if (key > arr[mid]) return BinarySearch(arr, key, mid + 1, right);
            return mid;
        }
    }
}
