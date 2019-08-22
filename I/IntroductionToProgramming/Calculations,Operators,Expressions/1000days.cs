using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            d = d.AddDays(999);
            Console.WriteLine(d.ToString("dd-MM-yyyy"));
        }
    }
}
