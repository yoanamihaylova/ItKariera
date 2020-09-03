using System;
using System.Linq;

namespace Tasks
{
    class Program
    {
        static bool[] used;
        static int[,] pr;
        static int n, sum, minSum = int.MaxValue;
        static void Main(string[] args)
        {
             n = int.Parse(Console.ReadLine());
            pr = new int[n, n];
            used = new bool[n];

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    pr[i, j] = numbers[i];
                }
                Calc(0);
                Console.WriteLine(minSum);
            }
            static void Calc (int pos)
            {
                if(pos == n)
                {
                    if (sum < minSum) minSum = sum;
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    if(!used[i])
                    {
                        used[i] = true;
                        sum += pr[i, pos];
                        Calc(pos + 1);
                        used[i] = false;
                        sum -= pr[i,pos];
                    }
                }
            }
        }
    }
}
