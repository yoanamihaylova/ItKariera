using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, t3;
            t1 = int.Parse(Console.ReadLine());
            t2 = int.Parse(Console.ReadLine());
            t3 = int.Parse(Console.ReadLine());
            int t = t1 + t2 + t3;
            Console.WriteLine("{0}:{1:d2}", t / 60, t % 60);

        }
    }
}
