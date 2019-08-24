using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(SquareRootMath.SquareRoot(num));
        }
    }
}
