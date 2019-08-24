using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Test4
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = arr.Count;
            Console.WriteLine(n);
            int evenCount = arr.Count(x => x % 2 == 0);
            Console.WriteLine(evenCount);
            int[] EvenNumbers = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", EvenNumbers));
            arr.Reverse();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
