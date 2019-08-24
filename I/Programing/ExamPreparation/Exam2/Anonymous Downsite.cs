using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Key = int.Parse(Console.ReadLine());
            decimal Loss = 0;
            List<string> list = new List<string>();
            List<string> names = new List<string>();
            for (int i = 0; i < N; i++)
            {
                list = Console.ReadLine().Split(' ').ToList();
                names.Add(list[0]);
                Loss = Loss + ( long.Parse(list[1]) * decimal.Parse(list[2]));
            }
            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Total Loss: {0:f20}",Loss);
            Console.WriteLine("Security Token: {0}",BigInteger.Pow(Key,N));
        }
    }
}
