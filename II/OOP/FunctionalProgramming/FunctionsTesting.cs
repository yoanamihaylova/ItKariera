using System;

namespace FunctionsTesting
{
    class FunctionsTesting
    {
        static void Main(string[] args)
        {
            Func<int, string> func = n => n.ToString();
            Console.WriteLine(func(34));

            Func<double, double> sqrt = n => Math.Sqrt(n);
            Console.WriteLine(sqrt(256));

            Action<string> print = meseage => Console.WriteLine(meseage);
            print("Hello,world!");

            int a = 5;
            int b = Operation(a, number => number * 5);
            int c = Operation(a, number => number - 3);
            int d = Operation(b, number => number % 2);

        }
        private static int Operation(int number, Func<int, int> operation)
        {
            return operation(number);
        }
    }
}
