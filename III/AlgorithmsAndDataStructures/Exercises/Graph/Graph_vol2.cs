using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_vol2
{
    class Graph_vol2
    {
        static List<int>[] G;
        static bool[] used;
        static int V;
        static void Main(string[] args)
        {
            V = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            G = new List<int>[V + 1];
            for (int i = 0; i < V+1; i++)
            {
                G[i] = new List<int>();
            }

            for (int i = 0; i < E; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = input[0];
                int y = input[1];
                G[x].Add(y);
                G[y].Add(x);
            }
            used = new bool[V + 1];
            DFS(1);
        }
        private static void DFS(int v)
        {
            Console.Write(v + " ");
            used[v] = true;
            int count = G[v].Count();
            for (int i = 0; i <count; i++)
            {
                if (!used[G[v][i]]) DFS(G[v][i]);
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