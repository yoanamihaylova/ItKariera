using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0;
            int num;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
            }
            Console.WriteLine("{0:f2} %", (p1 / n) * 100);
            Console.WriteLine("{0:f2} %", (p2 / n) * 100);
            Console.WriteLine("{0:f2} %", (p3 / n) * 100);
        }
    }
}
