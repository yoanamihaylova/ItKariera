using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l;
            n = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    for(char k='a';k<'a'+l; k++)
                    {
                        for(char m='a';m<'a'+l;m++)
                        {
                            for (int t = 1; t <= n; t++)
                            {
                                if (t > i && t > j) Console.Write("{0}{1}{2}{3}{4} ",i,j,k,m,t);
                            }
                        }
                    }
                }
            }
        }
    }
}
