using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikToc
{
    class TikToc
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                char[] RowArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = RowArray[j];
                }
            }
            bool win = false;
            char s='+';
            while (win != true)
            {
                int br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, i] == 'X') br++;
                }
                if (br==3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, i] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3 - 1; j >= 0; j--)
                    {
                        if (matrix[i, j] == 'X') br++;
                    }
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3 - 1; j >= 0; j--)
                    {
                        if (matrix[i, j] == 'O') br++;
                    }
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for(int i=0;i<3;i++)
                {
                    if (matrix[i, 0] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, 0] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, 1] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, 1] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, 2] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[i, 2] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[0, i] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[0,i] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[1, i] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[1, i] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[2, i] == 'X') br++;
                }
                if (br == 3) { s = 'X'; win = true; break; }
                br = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (matrix[2, i] == 'O') br++;
                }
                if (br == 3) { s = 'O'; win = true; break; }
                br = 0;


                win = true;
            }
            if (s == '+') Console.WriteLine("There is no winner");
            else Console.WriteLine("The winner is: {0}",s);
        }
    }
}
