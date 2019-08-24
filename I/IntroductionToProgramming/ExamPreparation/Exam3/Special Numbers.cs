using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            bool flag = false;
            int i = 1111;
            int c;
            int d=1;
            while(i<=9999)
            {
                flag = false;
                c = i;
                d = c % 10;
                while (c != 0)
                {

                    d = c % 10;
                    if (d != 0)
                    {
                        if (d > 0)
                        {
                            if (d == 0) { flag = false; break; }
                            if (N % d == 0) flag = true;
                            else { flag = false; break; }
                        }
                    }
                    else {flag = false; break;
                }
                    c /= 10;                   
                }
                if (flag == true) Console.Write(i+" ");
                i++;
            }
        }
    }
}
