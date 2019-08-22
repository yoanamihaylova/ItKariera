using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int min = a;
            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < min) min = a;
            }
            Console.WriteLine(min);
        }
    }
}
