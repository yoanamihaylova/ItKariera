using System;
using System.Linq;

namespace Graph
{
    class Graph
    {
        static bool[,] G;
        static bool []used;
        static int V;
        static int E;
        static void Main(string[] args)
        {
            //matrix
            V = int.Parse(Console.ReadLine());
            E = int.Parse(Console.ReadLine());

            G = new bool[V + 1, V + 1];
            for (int i = 0; i < E; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = input[0];
                int y = input[1];
                G[x, y] = G[y, x] = true;
            }
            used = new bool[V + 1];
            DFS(1);
        }

        private static void DFS(int v)
        {
            Console.Write(v + " ");
            used[v] = true;
            for (int i = 1; i <= V; i++)
            {
                if (G[v, i] == true && !used[i]) DFS(i);
            }
        }
    }
}
/*
4
5
1 2
1 4
2 3
2 4
3 4
----
7
11
1 4
1 7
2 3
2 4
2 5
2 6
2 7
3 5
3 6
4 6
5 7
 */