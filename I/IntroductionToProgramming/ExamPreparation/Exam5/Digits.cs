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
            int num;
            num = int.Parse(Console.ReadLine());
            int N, M;
            N = num / 100 + (num / 10) % 10;
            M = num / 100 + num % 10;
            int c = num;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (num % 5 == 0) num = num - c / 100;
                    else if (num % 3 == 0) num = num - c / 10 % 10;
                    else num = num + c % 10;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
