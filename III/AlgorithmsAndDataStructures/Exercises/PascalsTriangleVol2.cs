using System;

namespace PascalsTriangleVol2
{
    class PascalsTriangleVol2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] PascTriang = new int[n+1, n+1];
            for (int i = 0; i <= n; i++)
            {
                PascTriang[i, 0] = 1;
            }
            for (int i = 1; i <= n; i++)   
            {
                //PascTriang[i, 0] = 1;
                for (int j = 1; j <= n; j++)
                {
                    PascTriang[i, j] = PascTriang[i - 1, j - 1] + PascTriang[i - 1, j];
                }                
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(PascTriang[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
