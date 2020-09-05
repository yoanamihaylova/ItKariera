using System;
using System.Linq;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static int n;
        static int[] numbers;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            Destruction(n, 0);
        }
        static void Destruction(int n, int pos)
        {
            if(n==0)
            {
                Console.WriteLine(string.Join("+",numbers.Take(pos)));
                return;
            }
            for (int i = n; i >= 1; i--)
            {
                numbers[pos] = i;
                if (pos == 0 || numbers[pos] <= numbers[pos-1])
                    Destruction(n - i, pos + 1);
            }
        }
    }
}
