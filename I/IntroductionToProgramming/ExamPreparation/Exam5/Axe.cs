using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int dashl = 3 * n;
            int lenght = n * 5;
            Console.WriteLine(new string('-', dashl) + "**" + new string('-', lenght - 2 - dashl));
            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine(new string('-', dashl) + "*" + new string('-', i) + '*' + new string('-', lenght - (i + 2 + dashl)));
            }
            for (int i = 1; i <= n / 2; i++) Console.WriteLine(new string('*', dashl + 1) + new string('-', n - 1) + '*' + new string('-', lenght - (n - 1 + dashl + 2)));
            int dashi = n - 1;
            for (int i = 1; i < n / 2; i++)
            {
                Console.WriteLine("--" + new string('-', dashl - i - 1) + "*" + new string('-', dashi) + '*' + new string('-', lenght - (dashi + 2 + dashl - i + 1)));
                dashi += 2;
            }
            Console.WriteLine("--" + new string('-', dashl - n / 2 - 1) + "*" + new string('*', dashi) + '*' + new string('-', lenght - (dashi + 2 + dashl - n / 2 + 1)));
        }
    }
}