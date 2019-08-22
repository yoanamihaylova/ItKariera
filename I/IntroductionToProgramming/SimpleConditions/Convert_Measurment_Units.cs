using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Measurment_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double m;
            m = double.Parse(Console.ReadLine());
            string start, finish;
            start = Console.ReadLine();
            finish = Console.ReadLine();
            if (start == "mm") m /= 1000;
            if (start == "cm") m /= 100;
            if (start == "mi") m /= 0.000621371192;
            if (start == "in") m /= 39.3700787;
            if (start == "km") m /= 0.001;
            if (start == "ft") m /= 3.2808399;
            if (start == "yd") m /= 1.0936133;
            if (finish == "mm") m *= 1000;
            if (finish == "cm") m *= 100;
            if (finish == "mi") m *= 0.000621371192;
            if (finish == "in") m *= 39.3700787;
            if (finish == "km") m *= 0.001;
            if (finish == "ft") m *= 3.2808399;
            if (finish == "yd") m *= 1.0936133;
            Console.WriteLine("{0} {1}", m, finish);

        }
    }
}
