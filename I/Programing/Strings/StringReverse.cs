using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StirngReverse
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = a.Length-1; i >=0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}
