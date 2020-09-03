using System;
using System.Collections.Generic;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };
            Queue<int> resultCoins = new Queue<int>();

            int Total = 18;
            int currentSum = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > Total) continue;

                currentSum += coins[i];
                resultCoins.Enqueue(coins[i]);
                if (currentSum == Total)
                {
                    Console.WriteLine("Sum Found");
                    Console.WriteLine(Total + " = " + string.Join(" + ",resultCoins));
                    break;
                }  
                if(i == coins.Length-1) Console.WriteLine("Sum not found");

            }
        }
    }
}
