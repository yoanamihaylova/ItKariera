using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottaryTicket
{
    class LottaryTicket
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = lenght[0];
            int cols = lenght[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] RowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = RowArray[j];
                }
            }
            bool win = false;
            int md = 0;
            for (int i = 0; i < rows; i++) md += matrix[i, i];
            int sd = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = cols-1; j >= 0; j--) sd += matrix[i, j];
            }
            int under = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    under += matrix[i, j];
                }
            }
            int over = 0;
            for (int i = 1; i < rows-1; i++)
            {
                for (int j = i+1; j < cols; j++)
                {
                    over += matrix[i, j];
                }
            }
            if (md == sd) win = true;
            else if (over % 2 == 0) win = true;
            else if (under % 2 != 0) win = true;
            
            if(win==true)
            {
                double sum = 0;
                sum += under;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, i] % 2 == 0) sum += matrix[i, i];
                }
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[0, j] % 2 == 0) sum += matrix[0, j];
                    if (matrix[rows-1, j] % 2 == 0) sum += matrix[rows-1, j];
                }
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, 0] % 2 != 0) sum += matrix[i, 0];
                    if (matrix[i, cols-1] % 2 != 0) sum += matrix[i, cols-1];
                }
                sum /= 4.0;
                Console.WriteLine("YES");
                Console.WriteLine("The amount of money won is: {0:f2}",sum);
            }
            else Console.WriteLine("NO");
        }
    }
}
