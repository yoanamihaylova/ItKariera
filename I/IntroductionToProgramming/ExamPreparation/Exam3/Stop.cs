using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int inside = n * 2 + 1;
            Console.WriteLine(new string('.', dots) + new string('_', inside) + new string('.', dots));
            inside -= 2;
            int h = n*2+2;
            int w = n * 4 + 3;
            dots--;
            for (int i=2;i<h/2+1;i++)
            {
                Console.WriteLine(new string ('.',dots)+ "//" + new string ('_',inside)+ "\\\\" + new string ('.',dots));
                dots--;
                inside += 2;
            }
            dots -= h / 2 + 2;
            
            Console.WriteLine("//" + new string('_', (w-9)/2) + "STOP!" + new string('_', (w-9)/2) + "\\\\");
            dots = 0;
            for(int i=h/2+2;i<=h;i++)
            {
                Console.WriteLine(new string('.', dots ) + "\\\\" + new string('_', inside) + "//" + new string('.', dots ));
                inside -= 2;
                dots++;
            }
        }
    }
}
