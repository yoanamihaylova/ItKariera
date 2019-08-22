using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2} BGN", (num * (decimal)1.79549));

        }
    }
}
