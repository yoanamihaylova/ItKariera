using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, long>();
            long quantity;
            string input = Console.ReadLine();
            while (input!="stop")
            {

                quantity = long.Parse(Console.ReadLine());
                if (dict.ContainsKey(input))
                {
                    dict[input] += quantity;
                }
                else dict[input] = quantity;
                input = Console.ReadLine();

            }
            foreach (var item in dict) Console.WriteLine("{0} -> {1}",item.Key, item.Value);

        }
    }
}
