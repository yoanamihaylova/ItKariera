using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_Equal_to_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a;
            a = int.Parse(Console.ReadLine());
            int sum = a, max;
            max = a;
            for (int i = 1; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                sum += a;
                if (a > max) max = a;

            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sum - 2 * max));

            }
            }
        }
}
