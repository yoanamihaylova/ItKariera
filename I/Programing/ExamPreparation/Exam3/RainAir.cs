using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class RainAir
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, Array>();
            while(input!="I belive I can fly!")
            {
                string []line = input.Split(' ').ToArray();
                int[] a = new int [line.Count() - 1];
                for (int i = 1; i < line.Count(); i++)
                {
                    a[i-1] = int.Parse(line[i]);
                }
                dict.Add(line[0], a);
                if (input.Contains(" = "))
                {
                    string[] splitting = input.Split(new char[] { '=',' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                   // string []temp = dict.TryGetValue(splitting[0], out a[]);
                }
                else
                {
                    //if()
                }
                Console.WriteLine($"#{dict.Keys} ::: {string.Join(", ", dict.Values)}");
                input = Console.ReadLine();
            }

            {

            }
        }
    }
}
