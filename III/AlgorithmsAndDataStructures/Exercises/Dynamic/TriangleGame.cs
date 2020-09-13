using System;
using System.Linq;

namespace TriangleGame
{
    class TriangleGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] triangle = new int[n,n+1];
            int[,] v = new int[n,n+1];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n+1; j++)
                {
                    triangle[i, j] = line[j];
                }
            }
            v[0, 1] = triangle[0, 1];
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int fromUp = v[i - 1, j] + triangle[i, j];
                    int fromDiag = v[i - 1, j - 1] + triangle[i, j];
                    if (fromUp > fromDiag) v[i, j] = fromUp;
                    else v[i, j] = fromDiag;
                }
            }
            int max = v[n - 1, 0];
            for (int i = 1; i <= n; i++)
            {
                if (v[n - 1, i] > max) max = v[n - 1, i];
            }
            Console.WriteLine(max);

            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    Console.Write(v[i,j] + " ");
                }
                Console.WriteLine();
            }*/
        }

    }
}
/*
5
0 7 0 0 0 0
0 3 8 0 0 0
0 8 1 0 0 0
0 2 7 4 4 0
0 4 5 2 6 5
*/