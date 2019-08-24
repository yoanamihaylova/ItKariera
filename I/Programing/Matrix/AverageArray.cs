using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( matrix [i,j] + " "); sum += matrix[i, j]; 
                }
                Console.WriteLine(sum/(double)cols);
            }
        }
    }
}
