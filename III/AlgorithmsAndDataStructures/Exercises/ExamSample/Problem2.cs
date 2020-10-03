using System;
using System.Linq;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number1 = input[0];
            int number2 = input[1];
            Console.WriteLine(Multiply(number1, number2));
        }
        static int Multiply(int a, int b)
        {            
            if (a == 0 || b == 0) return 0;
            else if ( b == 1) return a;
            return a + Multiply(a, b - 1);
        }
    }
}
