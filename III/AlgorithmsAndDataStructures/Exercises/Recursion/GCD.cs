using System;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GCD_Subtraction(a,b));
            Console.WriteLine(GCD_Division(a,b));
        }
        static int GCD_Subtraction(int a, int b)
        {
            
            if (a == b) return a;
            if (a > b) return GCD_Subtraction(a - b, b);
            else return GCD_Subtraction(a, b - a);
        }
        static int GCD_Division(int a, int b)
        {
            if (b == 0) return a;
            return GCD_Division(b, a % b);
        }
    }
}
