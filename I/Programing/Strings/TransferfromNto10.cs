using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TransferfromNto10
{
    class TransferfromNto10
    {
        static void Main(string[] args)
        {
            BigInteger[] arr = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            //int n = arr[0];
            //int a = arr[1];
            int n = arr.Length;
            //string s = "";
            BigInteger sum=0;
            int i = 0;
            while(arr[1]!=0)
            {
                sum +=  arr[1] % 10*BigInteger.Pow(arr[0], i);
                i++;
                arr[1] /= 10;
                
            }
            Console.WriteLine(sum);
        }
    }
}
