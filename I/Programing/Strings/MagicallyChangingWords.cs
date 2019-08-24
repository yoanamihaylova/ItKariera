using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalyChangingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();
            string wl = a[0];
            wl = wl.ToLower();
            string wr = a[1];
            wr = wr.ToLower();
            int []brl = new int[27];
            int[] brr = new int[27];
          //  Console.WriteLine('a'-('a'-1));
            for(int i=0;i<wl.Length;i++)
            {
                int j = wl[i] - ('a' - 1);
                brl[j]++;
            }
            for (int i = 0; i < wr.Length; i++)
            {
                int j = wr[i] - ('a' - 1);
                brr[j]++;
            }
            Array.Sort(brl);
            Array.Sort(brr);
            int br1 = 0;
            int br2 = 0;
            for (int i = 0; i < brl.Length; i++)
            {
                if (brl[i] != 0) br1++;
            }
            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] != 0) br2++;
            }
            bool flag = true;
            /*if (brl.Length != brr.Length) flag = false;
            else
            {
                for (int i = 0; i < brl.Length; i++)
                {
                    if (brl[i] != brr[i]) { flag = false; break; }
                }
            }*/
            if (br1 != br2) flag = false;
            if (flag == true) Console.WriteLine("true");
            else Console.WriteLine("false");

        }
    }
}
