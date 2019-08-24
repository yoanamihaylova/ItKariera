using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int year;
            money = double.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            int age = 18;
            for(int i=1800;i<=year;i++)
            {
                if(i%2==0)
                {
                    money -= 12000;
                    age++;
                }
                else
                {
                    money = money - (12000 + 50 * age);
                    age++;
                }
            }
            if (money >= 0) Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left",money);
            else Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(money));

        }
    }
}
