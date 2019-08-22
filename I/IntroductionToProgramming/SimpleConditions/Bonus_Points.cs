using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double bonus = 0;
            num = int.Parse(Console.ReadLine());
            if (num <= 100) bonus = bonus + 5;
            else if ((num > 100) && (num < 1000)) bonus = bonus + num * (20 / 100.0);
            else if (num >= 1000) bonus = bonus + num * (10 / 100.0);
            if (num % 2 == 0) bonus++;
            else if (num % 10 == 5) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);

        }
    }
}
