using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel;
            cel = double.Parse(Console.ReadLine());
            Console.WriteLine(cel * (9.0 / 5.0) + 32.0);

        }
    }
}
