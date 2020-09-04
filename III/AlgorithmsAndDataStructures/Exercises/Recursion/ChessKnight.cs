using System;

namespace Horses
{
    class ChessKnight
    {
        static int n;
        static int count;
        static int current;
        static int[,] board;
      //  static int[,] board = new int[n, n];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            board = new int[n, n];
            Knight(0, 0);
        } 
        private static void Knight(int row, int col)
        {
            if (row < 0 || row >= n || col < 0 || col >= n) return;
            if (board[row, col] > 0) return;

            current++;
            board[row, col] = current;

            if (current == n * n )
            {
                Print();
            }

            Knight(row - 1, col + 2);
            Knight(row + 1, col + 2);
            Knight(row + 2, col + 1);
            Knight(row + 2, col - 1);
            Knight(row + 1, col - 2);
            Knight(row - 1, col - 2);
            Knight(row - 2, col - 1);
            Knight(row - 2, col + 1);
            current--;
            board[row, col] = 0;
        }
       
        private static void Print()
        {
            count++;
            Console.WriteLine($"Solution: {count}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(board[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
   
}
