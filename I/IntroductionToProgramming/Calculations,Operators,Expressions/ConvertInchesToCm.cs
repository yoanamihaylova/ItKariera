using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Inches_to_Cm
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(num * 2.54);

        }
    }
}
