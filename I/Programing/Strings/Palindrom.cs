using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] == a[a.Length - 1 - i]) flag = true;
                else {flag = false; break; }
            }
            if (flag == true) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
