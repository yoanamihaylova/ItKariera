using System;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList ds = new DynamicList();
            ds.Add(4);
            ds.Add(5);
            ds.Add(6);
            // ds.Remove(1);
            object t = 15;
            Console.WriteLine(ds[1]);
            Console.WriteLine(ds.IndexOf(t));
            Console.WriteLine(ds.Count);
        }
    }
}
