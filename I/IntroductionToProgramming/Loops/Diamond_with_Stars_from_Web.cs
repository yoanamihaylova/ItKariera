using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_with_Stars_from_Web
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c;
            n = int.Parse(Console.ReadLine());
            c = n;
            n = (n + 1) / 2;
            for (int i = 1; i < 2; i++)
            {
                Console.Write(new string('-', n - i));
                if (c % 2 == 0) Console.Write("**");
                else Console.Write("*");
                Console.WriteLine(new string('-',n-i));
               
            }
                for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write("-");
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                for (int j = 0; j < (n - i); j++)
                    Console.Write("-");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write("-");
                Console.Write("*");
                for (int j = 1; j < i; j++)
                    Console.Write("-");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                for (int j = 0; j < (n - i); j++)
                    Console.Write("-");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
    }

