using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveAdd_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            List<int> copy = new List<int>();
            if (list.Contains(num)) { copy = list; copy.Remove(num); }
            else
            {
                copy = list;
                copy.Add(num);
                copy.Sort();
                
            }
            Console.WriteLine(list);
            Console.WriteLine(copy);
        }
    }
}
