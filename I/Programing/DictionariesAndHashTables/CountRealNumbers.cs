using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().Select(double.Parse).ToArray();
            var dict = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict[item] = 1;
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
