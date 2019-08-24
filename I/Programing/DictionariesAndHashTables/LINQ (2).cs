using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Test3
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr.Length;
            Console.WriteLine(n);
            int evenCount = arr.Count(x => x % 2 == 0);
            Console.WriteLine(evenCount);
            int[] EvenNumbers = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ",EvenNumbers));
        }
    }
}
