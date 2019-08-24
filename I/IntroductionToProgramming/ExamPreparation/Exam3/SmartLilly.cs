using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double X,P;
            N = int.Parse(Console.ReadLine());
            X = double.Parse(Console.ReadLine());
            P = double.Parse(Console.ReadLine());
            double t = 0, sum = 0,br=0;
            for(int i=1;i<=N;i++)
            {
                if (i % 2 == 0) { br++; sum = sum + 10 * br; }
                else t++;
            }
            sum = sum - br;
            sum = sum + P * t;
            if (sum >= X) Console.WriteLine("Yes! {0:f2}", sum-X);
            else Console.WriteLine("No! {0:f2}", X-sum);
        }
    }
}
