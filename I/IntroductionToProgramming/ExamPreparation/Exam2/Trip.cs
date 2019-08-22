using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budget;
            string Season;
            Budget = double.Parse(Console.ReadLine());
            Season = Console.ReadLine();
            if (Budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (Season == "summer") Console.WriteLine("Camp - {0:f2}",Budget*0.3);
                else Console.WriteLine("Hotel - {0:f2}", Budget * 0.7);
            }
            else if(Budget >100 && Budget<=1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (Season == "summer") Console.WriteLine("Camp - {0:f2}", Budget * 0.4);
                else Console.WriteLine("Hotel - {0:f2}", Budget * 0.8);
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", Budget * 0.9);
             
            }
        }
    }
}
