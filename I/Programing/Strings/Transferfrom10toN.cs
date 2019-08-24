using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Transferform10toN
{
    class Transferfrom10toN
    {
        static void Main(string[] args)
        {
            BigInteger[] arr = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            //int n = arr[0];
            //int a = arr[1];
            string s = "";
            while(arr[1] != 0)
            {
                s = arr[1] % arr[0] + s;
                arr[1] /= arr[0];
            }
            
            Console.WriteLine(s);

        }
    }
}
