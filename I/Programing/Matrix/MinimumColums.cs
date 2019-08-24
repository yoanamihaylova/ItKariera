using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniColums
{
    class MinimumColums
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] RowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = RowArray[j];
                }
            }
            int[] Min = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int min = matrix[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];

                }
                Min[j] = min;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0,5}",matrix[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < cols; i++) Console.Write("{0,5}", Min[i]);
            Console.WriteLine();

        }
    }
}
