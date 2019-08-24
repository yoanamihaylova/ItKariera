using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal[] years = new decimal[N];
            int lbody, wing;
            decimal wbody;
            for (int i = 0; i < N; i++)
            {
                lbody = int.Parse(Console.ReadLine());
                wbody = decimal.Parse(Console.ReadLine());
                wing = int.Parse(Console.ReadLine());
                years[i] = (decimal)((decimal)lbody * lbody) * (wing * 2 + wbody);
            }
            for (int i = 0; i < N; i++) Console.WriteLine(years[i]);
        }
    }
}
