using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).Where(x=>(x%2)==0).ToArray();
            double average = 0;
            for (int i = 0; i < a.Length; i++)
            {
                average += a[i];
            }
            average /= a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > average) a[i]++;
                else if (a[i] < average) a[i]--;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
