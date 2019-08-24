using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(index));
        }

        private static int fibonacci(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;
            return fibonacci(index - 2) + fibonacci(index - 1);
        }
    }
}
