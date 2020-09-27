using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph_vol4
{
    class Graph_vol4
    {
        static Dictionary<int,List<int>> G;
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            G = new Dictionary<int, List<int>>();

            for (int i = 1; i < V+1; i++)
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
