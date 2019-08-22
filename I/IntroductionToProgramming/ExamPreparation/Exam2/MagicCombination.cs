using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for(int i=100000;i<=999999;i++)
            {
                int copy = i;
                int pr = 1;
                while (copy!=0)
                {
                    pr *= copy % 10;
                    copy /= 10;
                }
                if (pr == n) Console.Write("{0} ",i);
            }
        }
    }
}
