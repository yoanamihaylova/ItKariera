using System;
using System.Linq;

namespace Backpack
{
    class BackPack
    {
        static int Capacity, N;
        static int[] Weights;
        static int[] Price;
        static void Main(string[] args)
        {
            Capacity = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            Weights = new int[N];
            Price = new int[N];

            for (int i = 0; i < N; i++)
            {
                var Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Weights[i] = Input[0];
                Price[i] = Input[1];
            }
            Console.WriteLine(Calc(Capacity, 0));
        }
        static int Calc (int cap, int ind)
        {
            int maxSum = 0;
            int currentSum;
            for (int i = ind; i < N; i++)
            {
                if(Capacity - Weights[i] >= 0)
                {
                    currentSum = Calc(Capacity - Weights[i], i + 1) + Price[i];
                    if (currentSum > maxSum) maxSum = currentSum;
                }
            }
            return maxSum;
        }
    }
}
