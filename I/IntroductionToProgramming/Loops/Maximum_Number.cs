using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int max = a;
            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
            }
            Console.WriteLine(max);
        }
    }
}
