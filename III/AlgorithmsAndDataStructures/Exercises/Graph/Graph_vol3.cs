using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_vol._3
{
    class Graph_vol3
    {

        static List<int>[] G;
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            G = new List<int>[V + 1];

            for (int i = 1; i <= V; i++)
            {
                G[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
            }
        }
    }
}
/*
4
2 4
1 3 4
2 4
1 2 3
*/