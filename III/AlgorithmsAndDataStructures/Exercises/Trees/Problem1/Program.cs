using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problem1
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodes = new Dictionary<int, Tree<int>>();
        static void Main(string[] args)
        {
            ReadTree();
           // Console.WriteLine(GetRootNode().Value);
            var root = GetRootNode();
            //root.Print(0);
            List<Tree<int>> leaves = GetLeaves();
            leaves = leaves.OrderBy(x => x.Value).ToList();
            foreach (var leave in leaves)
            {
                Console.Write(leave.Value + " ");
            }
            Console.WriteLine();

            List<Tree<int>> middle = GetMiddleNodes();
            middle = middle.OrderBy(x => x.Value).ToList();
            foreach (var leave in middle)
            {
                Console.Write(leave.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine(DeepestElement().Value);

            currentRoute.Add(root);
            //longestRoute.Add(root);
            LongestRoute(root);
            foreach (var leave in longestRoute)
            {
                Console.Write(leave.Value + " ");
            }
            Console.WriteLine( );

            int sum = int.Parse(Console.ReadLine());
            currentRoute.Clear();
            currentRoute.Add(root);
            RouteSum(root, sum);
        }

        private static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddEdge(input[0], input[1]);
            }
        }

        static Tree<int> GetNodeByValue (int value)
        {
            if(!nodes.ContainsKey(value))
            {
                nodes[value] = new Tree<int>(value);
            }
            return nodes[value];
        }
        static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetNodeByValue(parent);
            Tree<int> childNode = GetNodeByValue(child);

            childNode.Parent = parentNode;
            parentNode.Children.Add(childNode);
        }
        static Tree<int> GetRootNode()
        {
            return nodes.Values.FirstOrDefault(x => x.Parent == null);
        }
        static List<Tree<int>> GetLeaves()
        {
            return nodes.Values.Where(x => x.Children.Count == 0).ToList();
        }
        static List<Tree<int>> GetMiddleNodes()
        {
            return nodes.Values.Where(x => x.Children.Count != 0 && x.Parent != null).ToList();
        }
        static Tree<int> DeepestElement()
        {
            var leaves = GetLeaves().ToList();
            //leaves = leaves.OrderBy(x => x.Value).ToList();
            Tree<int> deepest = leaves[0];
            int maxDepth = 0;
            foreach (var leaf in leaves)
            {
                int depth = 0;
                Tree<int> current = leaf;
                while (current.Parent != null)
                {
                    depth++;
                    current = current.Parent;
                }
                if (depth > maxDepth)
                {
                    deepest = leaf;
                    maxDepth = depth;
                }
            }
            return deepest;
        }
        static List<Tree<int>> currentRoute = new List<Tree<int>>();
        static List<Tree<int>> longestRoute = new List<Tree<int>>();

        static void LongestRoute(Tree<int> node)
        {
            if(currentRoute.Count>longestRoute.Count)
            {
                longestRoute = currentRoute.ToList();
            }
            foreach (var child in node.Children)
            {
                currentRoute.Add(child);
                LongestRoute(child);
                currentRoute.RemoveAt(currentRoute.Count - 1);
            }
        }
        static void RouteSum(Tree<int> node, int sum)
        {
            if (currentRoute.Sum(x => x.Value)== sum)
            {
                foreach (var item in currentRoute)
                {
                    Console.Write(item.Value + " ");
                }
                Console.WriteLine();
                return;
            }
            foreach (var child in node.Children)
            {
                currentRoute.Add(child);
                RouteSum(child,sum);
                currentRoute.RemoveAt(currentRoute.Count - 1);
            }
        }
      /*  static int GetSubTreeSum(Tree <int> node, int sum, int currentSum)
        {
            ///int currentSum = 0;
            Console.Write(new string(' ', indent * 2));
            Console.WriteLine(Value);

            if(currentSum == sum)

            foreach (var child in node.Children)
            {
                child.GetSubTreeSum(;
            }
        }*/
    }
}
/*
9
7 19
7 21
7 14
19 1
19 12
19 31
14 23
14 6
 */