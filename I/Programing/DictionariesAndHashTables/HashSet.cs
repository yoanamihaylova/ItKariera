using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(6);
            hashSet.Add(4);
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(3);
            Console.WriteLine(string.Join(" ",hashSet));
        }
    }
}
