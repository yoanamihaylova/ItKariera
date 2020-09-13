using System;
using System.Linq;

namespace Alley
{
    class Alley
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var d = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] br = new int [length+1];
            br[0] = 1;
            int sum = 0;
            for (int i = 1; i <= length; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i - d[j] >= 0) sum += br[i - d[j]];
                }
                br[i] = sum;
            }
            Console.WriteLine(br[length]);
        }
    }
}
/*
5 
3
2 1 3
*/