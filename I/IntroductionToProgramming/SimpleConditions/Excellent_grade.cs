using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50) Console.WriteLine("Excellent!");

        }
    }
}
