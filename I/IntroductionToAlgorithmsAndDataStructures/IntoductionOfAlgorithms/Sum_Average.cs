using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Averrage
{
    class Sum_Average
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = numbers.Sum(x => x);
            double average = numbers.Average(x => x);
            Console.WriteLine("Sum={0}; Average={1:f2}",sum,average);
        }
    }
}
