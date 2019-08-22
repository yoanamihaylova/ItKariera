using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USD, EUR, GBP;
            USD = (decimal)1.79549;
            EUR = (decimal)1.95583;
            GBP = (decimal)2.53405;
            decimal value;
            value = decimal.Parse(Console.ReadLine());
            string start;
            string final;
            start =(Console.ReadLine());
            final = (Console.ReadLine());
            if(start == "BGN")
            {
                if (final == "USD") Console.WriteLine("{0:f2}", value / USD);
                if (final == "EUR") Console.WriteLine("{0:f2}", value / EUR);
                if (final == "GBP") Console.WriteLine("{0:f2}", value / GBP);
            }
            if (start == "USD")
            {
                if (final == "BGN") Console.WriteLine("{0:f2}", value * USD);
                if (final == "EUR") Console.WriteLine("{0:f2}", (value * USD) / EUR);
                if (final == "GBP") Console.WriteLine("{0:f2}", (value * USD) / GBP);
            }
            if (start == "EUR")
            {
                if (final == "USD") Console.WriteLine("{0:f2}", (value * EUR) / USD);
                if (final == "GBP") Console.WriteLine("{0:f2}", (value * EUR) / GBP);
                if (final == "BGN") Console.WriteLine("{0:f2}", value * EUR);
            }
            if (start == "GBP")
            {
                if (final == "BGN") Console.WriteLine("{0:f2}", value * GBP);
                if (final == "EUR") Console.WriteLine("{0:f2}", (value * GBP) / EUR);
                if (final == "USD") Console.WriteLine("{0:f2}", (value * GBP) / USD);
            }
        }
    }
}
