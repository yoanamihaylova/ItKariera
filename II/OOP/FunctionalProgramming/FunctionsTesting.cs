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
        }
    }
}
