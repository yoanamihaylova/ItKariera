using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBigNumbers
{
    class AddBigNumbers
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().TrimStart(new char[] { '0'});
            string b = Console.ReadLine().TrimStart(new char[] { '0'});
            string sum = "";
            int ost = 0;
            int l;
            if (a.Length > b.Length)
            {
                l = a.Length;
                for (int i = b.Length - 1; i < l-1; i++)
                {
                    b = "0" + b;
                }
            }
            else
            {
                l = b.Length;
                for (int i = a.Length - 1; i < l-1; i++)
                {
                    a = "0"+a;
                }
            }
          // Console.WriteLine(a);
           //Console.WriteLine(b);
            for (int i = l - 1; i >= 0; i--)
            {
                    sum =(((a[i] - '0') + (b[i] - '0') + ost) % 10)+sum;
                    ost = ((a[i] - '0') + (b[i] - '0') + ost) / 10;
            }
            if(ost>0) sum = ost + sum;
            sum = sum.TrimStart(new char[] {'0'});
            Console.WriteLine(sum);
        }
    }
}
