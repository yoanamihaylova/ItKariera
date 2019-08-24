using System;
using System.Collections.Generic;
using System.Text;

namespace EightQueens
{
     public class EightQueens
    {
        const int Size = 8;
        static int solution = 0;
        static bool[,] board = new bool[Size, Size];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeft = new HashSet<int>();
        static HashSet<int> attackedRight = new HashSet<int>();

        public static void PutQueens(int row)
        {
            if (row == Size) PrintSolution();
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if(CanPlaceQueen(row,col))
                    {
                        MarkAllAtackedPosition(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAtackedPosition(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAtackedPosition(int row, int col)
        {
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeft.Remove(col - row);
            attackedRight.Remove(col + row);
            board[row, col] = false;
        }

        private static void MarkAllAtackedPosition(int row, int col)
        {
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeft.Add(col - row);
            attackedRight.Add(col + row);
            board[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var Yes = !attackedRows.Contains(row) && !attackedCols.Contains(col) && !attackedLeft.Contains(col - row) && !attackedRight.Contains(row+col);
            return Yes;
        }

        private static void PrintSolution()
        {
            solution++;
            Console.WriteLine(solution);
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (board[row, col] == true) Console.Write("*");
                    else Console.Write("-");
                    
                }Console.WriteLine();
            }
        }
    }
}
