using System;
using System.Collections.Generic;
using System.Linq;

namespace Maze
{
    class Maze
    {
        static int []nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        static int n = nm[0];
        static int m = nm[1];
        static char[,] maze = new char[n, m];
        static List<char> moves = new List<char>();
        static void Main(string[] args)
        {
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    maze[i, j] = input[j];
                }
            }
            /*  for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < m; j++)
                  {
                      Console.Write(maze[i,j]);
                  }
                  Console.WriteLine();
              }*/
            ExitPaths(0, 0, 'S');

        }

        private static void ExitPaths(int row, int col, char direction)
        {
            if (row < 0 || row >= n || col < 0 || col >= m) return;
            if (maze[row, col] == '*') return;
            moves.Add(direction);
            if(maze[row, col] == 'e') Console.WriteLine(string.Join(" ", moves.Skip(1)));

            if (maze[row, col] == '-')
            {
                maze[row, col] = 'v';
                ExitPaths(row, col + 1, 'R');
                ExitPaths(row + 1, col, 'D');
                ExitPaths(row - 1, col, 'U');
                ExitPaths(row, col - 1, 'L');
                maze[row, col] = '-';

            }

            moves.Remove(moves[moves.Count() - 1]);

        }
    }
}
/*
3 3
---
-*-
--e
*/