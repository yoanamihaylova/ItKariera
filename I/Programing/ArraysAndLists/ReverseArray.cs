using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for(int i=0;i<n/2;i++)
            {
                temp = a[i];
                a[i] = a[n - i - 1];
                a[n - 1 - i] = temp;
            }
            for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " ");
        }
    }
}
