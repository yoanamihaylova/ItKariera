using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int dots = n;
            Console.WriteLine(new string ('.',dots)+ new string('*',5*n-2*n)+ new string('.', dots));
            for(int i=2;i<=n;i++)
            {
                Console.WriteLine(new string('.', dots+1-i)+"*"+new string('.',5*n-(2+2*(dots+1-i)))+"*"+ new string('.', dots+1-i));
            }
            Console.WriteLine(new string('*',5*n));
            dots = 1;
            for(int i=n+2;i< 3 * n + 2;i++)
            {
                Console.WriteLine(new string('.',dots)+"*"+ new string('.', 5 * n - (2 + 2 * dots )) + "*" + new string('.', dots ));
                dots++;
            }
            Console.WriteLine(new string('.', dots) + "*" + new string('*', 5 * n - (2 + 2 * dots)) + "*" + new string('.', dots));
        }
    }
}
