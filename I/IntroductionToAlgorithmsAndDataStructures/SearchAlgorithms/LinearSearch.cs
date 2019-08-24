using System;
using System.Linq;

namespace LinearSearch
{
    class Linear_Searxh
    {
        static void Main(string[] args)
        {
            int []arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine( LinearSearch(arr,n )); 
        }
        public static int LinearSearch(int [] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element) return i;
                 
            }
            return -1;
        }
    }
}
