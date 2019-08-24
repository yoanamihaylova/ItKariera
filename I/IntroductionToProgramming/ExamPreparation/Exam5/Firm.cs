using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, days, employees;
            hours = int.Parse(Console.ReadLine());
            days = int.Parse(Console.ReadLine());
            employees = int.Parse(Console.ReadLine());
            double h = (days - (days/10.0))*8;
            
            int he = (employees * (2 * days));
            double sum = h + he;
            sum = Math.Floor(sum);
            if (sum >= hours) Console.WriteLine("Yes!{0} hours left.", Math.Floor(sum - hours));
            else Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(hours - sum));
        }
    }
    
}
