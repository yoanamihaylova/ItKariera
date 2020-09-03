using System;

namespace LCM
{
    class LCM
    {
        static void Main(string[] args)
        {
           //Не работи!
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a*b/GCD_Division(a,b));
        }
        static int GCD_Division(int a, int b)
        {
            if (b == 0) return a;
            return GCD_Division(b, a % b);
        }

    }
}
