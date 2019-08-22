using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.Write(new string('-', (n - 1) / 2));
            if (n % 2 == 0) Console.Write("**");
            else Console.Write("*");
            Console.WriteLine(new string('-', (n - 1) / 2));
            for (int i = 2; i <= n; i++)
            {
                // string outside = new string('-', (n + 1) / 2 - i);
                int outside = n - i;
                string inside = new string('-', n - 2 - 2 *outside );
                Console.WriteLine(new string('-',outside) + "*" + inside + "*" + new string('-',outside));
            }
            for(int i=1;i<=(n-1)/2;i++)
            {
                for (int j = 0; j < i; j++) Console.Write("-");
                string inside = new string('-', n - 2 - 2 * i);
                Console.Write("*"+inside+"*");
                for (int j = 0; j < i; j++) Console.Write("-");
                Console.WriteLine();
            }
          /*  if (n % 2 != 0)
            {
                Console.Write("*");
                for (int j = 0; j < i; j++) Console.Write("-");
            }*/


        }
    }
}
