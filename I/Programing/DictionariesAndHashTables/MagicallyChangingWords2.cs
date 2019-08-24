using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicallyChangingWords2
{
    class MagicallyChangingWords2
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();
            string wl = a[0];
            wl = wl.ToLower();
            string wr = a[1];
            wr = wr.ToLower();
            HashSet<char> left = new HashSet<char>(); 
            for(int i=0; i < wl.Length; i++)
            {
                left.Add(wl[i]);
            }
            HashSet<char> right = new HashSet<char>();
            for (int i = 0; i < wr.Length; i++)
            {
                right.Add(wr[i]);
            }
            if (left.Count() == right.Count()) Console.WriteLine("true");
            else Console.WriteLine("false");

        }
    }
}
