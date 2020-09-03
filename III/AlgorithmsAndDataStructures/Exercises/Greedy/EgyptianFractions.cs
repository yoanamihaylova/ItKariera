using System;
using System.Linq;

namespace EgyptianFraction
{
    class EgyptianFractions
    {
        static void Main(string[] args)
        {
            /* int p = 7;
             int q = 9;*/
            int p, q;
            var input = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
            p = input[0];
            q = input[1];
            if (p >= q)
            {
                Console.WriteLine("Error (fraction is equal to greater than 1)");
                return;

            }
            int r;
            Console.Write($"{p}/{q} = ");
            //= (q + p) / p;
            int d = GCD(p, q);
            p = p / d;
            q = q / d;
            while (p>1)
            {
                r = (p + q) / p;
                Console.Write($"1/{r} +");
                p = p*r -q;
                q = q * r;
                d = GCD(p, q);
                p = p / d;
                q = q / d;
                
            }Console.WriteLine($"1/ {q}");
        }
        static int GCD (int a, int b)
        {
            int r;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
