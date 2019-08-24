using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, S;
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());
            for(int i=M;i>=N;i--)
            {

                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == S) break;
                    else Console.Write(i + " ");
                }
            }
        }
    }
}
