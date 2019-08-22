using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            int t = hour * 60 + minutes + 15;
            hour = t / 60 % 24;
            minutes = t % 60;
            Console.WriteLine("{0}:{1:d2}", hour, minutes);

        }
    }
}
