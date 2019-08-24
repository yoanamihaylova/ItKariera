using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Shuffle(arr);
            QuickSort(arr,0,arr.Length-1);
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void QuickSort<T>(T[] arr, int left, int right) where T : IComparable
        {
            int i = left;
            int j = right;
            int midInd = (left + right) / 2;
            T mid = arr[midInd];
            while(i <= j)
            {
                while (Less(arr[i], mid)) i++;
                while (Less(mid, arr[j])) j--;
                if (i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }
            if(left < j) QuickSort(arr, left, j);
            if(i < right) QuickSort(arr, i, right);
            
        }
        private static void Shuffle<T>(T[] arr) 
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int r = i + rnd.Next(arr.Length - i - 1);
                Swap(arr, i, r);
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void MergeSort<T>(T[] arr, int left, int right) where T:IComparable
        {
            if (right <= left) return;
            int mid = (left + right) / 2;
            //разделяне
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            //сливане
            T[] temp = new T[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while(i <= mid && j <= right)
            {
                if (Less(arr[i], arr[j])) temp[k++] = arr[i++];
                else temp[k++] = arr[j++];
            }
            while (i <= mid) temp[k++] = arr[i++];
            while (j <= right) temp[k++] = arr[j++];
            for (i = left; i <= right; i++)
            {
                arr[i] = temp[i - left];
            }

        }
        private static void InsertionSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j>0 && Less(arr[j],arr[j-1]))
                {
                    Swap(arr, j, j - 1);
                    j--;
                }
                
            }Console.WriteLine(string.Join(" ", arr));
        }
        private static void BubbleSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (Less(arr[j + 1], arr[j])) Swap(arr, j + 1, j);
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void SelectionSort<T>(T[] arr) where T:IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Less(arr[j], arr[indexMin])) indexMin = j;
                }
                Swap(arr, i, indexMin);
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Swap <T> (T [] collection , int from, int to)
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
