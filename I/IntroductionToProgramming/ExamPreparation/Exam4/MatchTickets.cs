using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget;
            string category;
            int br;
            budget = double.Parse(Console.ReadLine());
            category = Console.ReadLine();
            br = int.Parse(Console.ReadLine());
            double sum = 0.0;
            if (category=="VIP")
            {
                if (br <= 4)
                {
                    sum = 75.0 / 100 * budget;
                    if (budget - sum >= 499.99*br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget-sum)-499.99*br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.",499.99*br-(budget-sum));
                }
                else if(br>4 && br<=9)
                {
                    sum = 60.0 / 100 * budget;
                    if (budget - sum >= 499.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 499.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99 * br - (budget - sum));
                }
                else if(br > 9 && br <= 24)
                {
                    sum = 50.0 / 100 * budget;
                    if (budget - sum >= 499.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 499.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99 * br - (budget - sum));
                }
                else if(br > 24 && br <= 49)
                {
                    sum = 40.0 / 100 * budget;
                    if (budget - sum >= 499.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 499.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99 * br - (budget - sum));
                }
                else
                {
                    sum = 25.0 / 100 * budget;
                    if (budget - sum >= 499.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 499.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99 * br - (budget - sum));
                }
            }
            else
            {
                if (br <= 4)
                {
                    sum = 75.0 / 100 * budget;
                    if (budget - sum >= 249.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 249.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 * br - (budget - sum));
                }
                else if (br > 4 && br <= 9)
                {
                    sum = 60.0 / 100 * budget;
                    if (budget - sum >= 249.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 249.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 * br - (budget - sum));
                }
                else if (br > 9 && br <= 24)
                {
                    sum = 50.0 / 100 * budget;
                    if (budget - sum >= 249.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 249.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 * br - (budget - sum));
                }
                else if (br > 24 && br <= 49)
                {
                    sum = 40.0 / 100 * budget;
                    if (budget - sum >= 249.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 249.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 * br - (budget - sum));
                }
                else
                {
                    sum = 25.0 / 100 * budget;
                    if (budget - sum >= 249.99 * br) Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - sum) - 249.99 * br);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 * br - (budget - sum));
                }
            }
        }
    }
}
