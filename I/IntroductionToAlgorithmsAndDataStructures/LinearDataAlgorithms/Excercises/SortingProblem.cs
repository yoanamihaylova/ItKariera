using System;
using System.Linq;

namespace SortingProblem
{
    class SortingProblem
    {
        static void Main(string[] args)
        {
            int []arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort(arr);
            Console.WriteLine("Final:");
            Console.WriteLine(string.Join(' ',arr));

        }
            public static void SelectionSort<T>(T[] a) where T: IComparable
            {
                for (int i = 0; i < a.Length-1; i++)
                {
                    int minIndex = i;
                    for (int j = i+1; j < a.Length; j++)
                    {
                        if (Less(a[j], a[minIndex])) minIndex = j;
                    }
                    Swap(a ,i , minIndex);
                }
                
            }
            static void Swap<T>(T[] collection, int from, int to)
            {
                Console.WriteLine($"Swapping: {collection[from]} and {collection[to]}");
                T temp = collection[from];
                collection[from] = collection[to];
                collection[to] = temp;
                Console.WriteLine(string.Join(' ',collection));
            }
            static bool Less(IComparable first, IComparable second)
        {
                return first.CompareTo(second) < 0;
            }
    }
}
