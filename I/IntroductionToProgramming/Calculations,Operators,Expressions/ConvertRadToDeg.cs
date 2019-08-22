using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Rad_to_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double num;
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((num * 180.0) / pi));

        }
    }
}
