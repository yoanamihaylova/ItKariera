using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class SortNumbeers
    {
        static void Main(string[] args)
        {
            List<double> names = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            names.Sort();
            names.Reverse();
            for (int i = 0; i < names.Count; i++)
            {
                double x = Math.Sqrt(names[i]);
                x = (int)x;
                if (x * x == names[i]) Console.Write(names[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
