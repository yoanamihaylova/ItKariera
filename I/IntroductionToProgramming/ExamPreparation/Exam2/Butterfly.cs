using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int w,h;
            w = 2 * n - 1;
            h = 2 * (n - 1) + 1;
            int stars = n - 2;
            for (int i = 0; i < h/2-1; i++)
            {
                if (i % 2 == 0) Console.WriteLine(new string('*',stars) + "\\ /" + new string ('*',stars));
                else Console.WriteLine(new string('-', stars) + "\\ /" + new string('-', stars));
            }
            Console.WriteLine(new string(' ', stars) + " @ " + new string(' ', stars));
            for(int i=h/2+2;i<h;i++)
            {
                if (i % 2 == 0) Console.WriteLine(new string('*', stars) + "/ \\" + new string('*', stars));
                else Console.WriteLine(new string('-', stars) + "/ \\" + new string('-', stars));
            }
        }
    }
}
