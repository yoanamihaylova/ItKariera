using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> names = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            names.Sort();
            for(int i=0;i<names.Count-1;i++)
            {
                Console.Write(names[i]+ " <=");
            }
            Console.Write(" "+names[names.Count-1]);
            Console.WriteLine();
        }
    }
}
