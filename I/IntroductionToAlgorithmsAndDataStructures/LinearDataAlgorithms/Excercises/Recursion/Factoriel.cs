using System;

namespace ConsoleApp1
{
    class Factoriel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(factoriel(n));
        }

        private static int factoriel(int n)
        {
            if (n == 0) return 1;
            return n*factoriel(n - 1);
        }
    }
}
