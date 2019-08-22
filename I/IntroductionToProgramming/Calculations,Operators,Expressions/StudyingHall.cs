using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, h;
            w = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            int cmw = (int)w * 100;
            int cmh = (int)h * 100;
            //Изведи броя на местата в залата
            Console.WriteLine(((cmw/120) * (cmh/70)) - 3);
        }
    }
}
