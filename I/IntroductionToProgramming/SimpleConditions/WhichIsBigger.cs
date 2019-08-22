using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Which_is_bigger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2) Console.WriteLine(n1);
            else Console.WriteLine(n2);

        }
    }
}
