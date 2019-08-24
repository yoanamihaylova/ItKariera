using System;
using System.Linq;

namespace CrossRunning
{
    class CrossRunning
    {
        static void Main(string[] args)
        {
            int[] line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = line1.Concat(line2).ToArray();
            SelectionSort(arr);
            Console.WriteLine(string.Join(' ',arr));
        }
        public static void SelectionSort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Less(a[j], a[minIndex])) minIndex = j;
                }
                Swap(a, i, minIndex);
            }

        }
        static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }
        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
