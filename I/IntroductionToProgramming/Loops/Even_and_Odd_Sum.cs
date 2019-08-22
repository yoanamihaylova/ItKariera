using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int a;
            int esum = 0, osum = 0;
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i % 2 == 0) esum += a;
                else osum += a;
            }
            if (esum == osum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", esum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(esum - osum));
            }
            }
        }
}
