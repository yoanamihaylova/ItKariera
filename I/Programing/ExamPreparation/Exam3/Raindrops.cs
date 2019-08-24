using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Raindrops
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double thickness = double.Parse(Console.ReadLine());
            if (thickness == 0) thickness ++;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                double []line = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                sum += line[0] / line[1];
            }
            Console.WriteLine(sum/thickness);
        }
    }
}
