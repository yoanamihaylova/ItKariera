using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a;
            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                sum1 += a;
            }
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                sum2 += a;
            }
            if (sum1 == sum2) Console.WriteLine("Yes, sum={0}", sum1);
            else Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}
