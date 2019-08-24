using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",centuries,centuries*100,(int)(centuries*100*365.2422),(int)( centuries * 100 * 365.2422*24),(int)( centuries * 100 * 365.2422*24*60));
        }
    }
}
