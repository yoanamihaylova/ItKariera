using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
        static int Fib (int n)
        {
            if (n == 1 || n == 2) return 1;
            return Fib(n - 1) + Fib(n-2);
        }
    }
}
