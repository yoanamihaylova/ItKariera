using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month;
            int Days;
            Month = Console.ReadLine();
            Days = int.Parse(Console.ReadLine());
            // Month = Month.ToLower();
            if (Days <= 7)
            {
                if (Month == "May" || Month == "October")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 65.00);
                    Console.WriteLine("Studio: {0:f2} lv.", Days * 50.00);
                }
                if (Month == "June" || Month == "September")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 68.70);
                    Console.WriteLine("Studio: {0:f2} lv.", Days *75.20);
                }
                if (Month == "August" || Month == "July")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 77.00);
                    Console.WriteLine("Studio: {0:f2} lv.", Days * 76.00);
                }
            }
            else if (Days > 7 && Days <= 14)
            {
                if (Month == "May" || Month == "October")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 65.00);
                    Console.WriteLine("Studio: {0:f2} lv.", Days * (50.00 - 2.5));
                }
                else if (Month == "June" || Month == "September")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 68.70);
                    Console.WriteLine("Studio: {0:f2} lv.", Days * 75.20);
                }
                else if (Month == "August" || Month == "July")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * 77.00);
                    Console.WriteLine("Studio: {0:f2} lv.", Days * 76.00);
                }
            }
            else if (Days > 14)
            {
                if (Month == "May" || Month == "October")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * (65.00 - 6.5));
                    Console.WriteLine("Studio: {0:f2} lv.", Days * (50.00 - 15));
                }
                if (Month == "June" || Month == "September")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * (68.70 - 6.87));
                    Console.WriteLine("Studio: {0:f2} lv.", Days * (75.20 - 15.04));
                }
                if (Month == "August" || Month == "July")
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", Days * (77.00 - 7.7));
                    Console.WriteLine("Studio: {0:f2} lv.", Days * 76.00);
                }
            }
        }
    }
}
