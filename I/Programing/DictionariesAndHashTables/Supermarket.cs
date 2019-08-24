using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            Dictionary<string, Tuple<double, int>> dict = new Dictionary<string, Tuple<double, int>>();
            while (input[0]!="stocked")
            {
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                int oldQuantity = 0;
                if(dict.ContainsKey(name))
                {
                    oldQuantity = dict[name].Item2;
                }
                dict[name] = new Tuple<double, int>(price, quantity + oldQuantity);
                input = Console.ReadLine().Split(' ');
            }
            double sum = 0;
            foreach (var item in dict)
            {
                Console.Write(item.Key+": $"+item.Value.Item1 +"*"+ item.Value.Item2+ " = ");
                Console.WriteLine($"${item.Value.Item1*item.Value.Item2 :f2}");
                sum += item.Value.Item1 * item.Value.Item2;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand total: ${0:f2}",sum);
        }
    }
}
