using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simmilar_Coupels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int currentsum = 0;
            int prevsum = 0;
            prevsum = a + b;
            int max = 0;
            int diff;
            for (int i = 2; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                currentsum = a + b;
                diff = (Math.Abs(currentsum - prevsum));
                if (diff > max) max = diff;
                prevsum = currentsum;
            }
            if (max == 0) Console.WriteLine("Yes, value={0}", prevsum);
            else Console.WriteLine("No, maxdiff={0}", max);

        }
    }
}
