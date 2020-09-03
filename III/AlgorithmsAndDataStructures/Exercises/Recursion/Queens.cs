using System;
using System.Collections.Generic;

namespace Queens
{
    class Queens
    {
        static int count = 0;
        static int size = 8;
        static bool[,] board = new bool[size, size];
        static List<int> takenRows = new List<int>();
        static List<int> takenCols = new List<int>();
        static List<int> takenDiag1 = new List<int>();
        static List<int> takenDiag2 = new List<int>();
        static void Main(string[] args)
        {
            PlaceQueen(0);
        }

        static void PlaceQueen(int row)
        {
            if (row == size) Print();
            for (int col = 0; col < size; col++)
            {
                if (!TakenCell(row, col))
                {
                    TakenPositions(row, col);
                    PlaceQueen(row + 1);
                    FreePositions(row, col);
                }
            }
        }

        private static void TakenPositions(int row, int col)
        {
            takenRows.Add(row);
            takenCols.Add(col);
            takenDiag1.Add(row - col);
            takenDiag2.Add(row + col);
            board[row, col] = true;
        }        
        private static void FreePositions(int row, int col)
        {
            takenRows.Remove(row);
            takenCols.Remove(col);
            takenDiag1.Remove(row - col);
            takenDiag2.Remove(row + col);
            board[row, col] = false;
        }

        private static bool TakenCell(int row, int col)
        {
            return takenRows.Contains(row) || takenCols.Contains(col) || takenDiag1.Contains(row - col) || takenDiag2.Contains(row + col);
        }

        private static void Print()
        {
            count++;
            Console.WriteLine($"Solution: {count}"); 

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (board[row, col]) Console.Write("* ");
                    else Console.Write("- ");
               
                }     Console.WriteLine();
            }
        }
    }
}
