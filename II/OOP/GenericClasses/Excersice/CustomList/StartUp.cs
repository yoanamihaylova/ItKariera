using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                var line = command.Split();
                if (line[0] == "Add")
                {
                    list.Add(line[1]);
                }
                if (line[0] == "Remove")
                {
                    Console.WriteLine(list.Remove(int.Parse(line[1])));
                }
                if (line[0] == "Contains")
                {
                    Console.WriteLine(list.Contains(line[1]));
                }
                if (line[0] == "Swap")
                {
                    list.Swap(int.Parse(line[1]), int.Parse(line[2]));
                }
                if (line[0] == "Greater")
                {
                    Console.WriteLine(list.CountGreaterThan(line[1]));
                }
                if (line[0] == "Max")
                {
                    Console.WriteLine(list.Max());
                }
                if (line[0] == "Min")
                {
                    Console.WriteLine(list.Min());

                }
                if (line[0] == "Print")
                {
                    Console.WriteLine(list);
                }
                if(line[0] == "Sort")
                {
                    list.Sort();
                }
            }
        }
    }
}