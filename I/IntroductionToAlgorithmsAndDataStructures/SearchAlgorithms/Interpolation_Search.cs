using System;
using System.Linq;

namespace InterpolationSearch
{
    class Interpolation_Search
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(InterpolationSearch(arr,key));
        }
        public static int InterpolationSearch(int [] arr , int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left<=right)
            {
                int mid = left + (key - arr[left]) * (right - left) / (arr[right] - arr[left]);
                if (key < arr[mid]) right = mid - 1;
                else if (key > arr[mid]) left = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}
