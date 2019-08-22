using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, h;
            h = double.Parse(Console.ReadLine());
            w = double.Parse(Console.ReadLine());
            w = w * 100;
            h = h * 100;
            w = w - 100;
            Console.WriteLine((int)(w/70)*(int)(h/120)-3);
        }
    }
}
