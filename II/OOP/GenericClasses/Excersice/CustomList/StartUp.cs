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
            string []line = Console.ReadLine().Split(' ').ToArray();
            CustomList<string> list = new CustomList<string>();
            while (line[0] != "END")
            {
                
                if(line[0] == "Add")
                {
                    list.Add(line[1]);
                }
                else if(line[0] == "Remove")
                {
                    Console.WriteLine(list.Remove(int.Parse(line[1]))); 
                }
                else if(line[0] == "Conatins")
                {
                    Console.WriteLine(list.Contains(line[1])); 
                }
                else if(line[0] == "Swap")
                {
                    list.Swap((int.Parse(line[1])), (int.Parse(line[2])));
                }
                else if(line[0] == "Greater")
                {
                    Console.WriteLine( list.CountGreaterThan(line[1]) ); 
                }
                else if(line[0] == "Max")
                {
                    Console.WriteLine( list.Max());
                }
                else if(line[0] == "Min")
                {
                    Console.WriteLine( list.Min() ); 
                }
                else if(line[0] == "Print")
                {
                    list.ToString();
                }
                line = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
