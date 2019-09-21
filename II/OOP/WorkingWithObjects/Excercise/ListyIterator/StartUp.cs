using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>();
            var line = Console.ReadLine().Split(' ').ToArray();
            while(line[0] != "END")
            {
                if(line[0] == "Create")
                {
                    list.Create(line.Skip(1).ToArray());
                }
                if(line[0] == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                if(line[0] == "Print")
                {
                    list.Print();
                }
                if(line[0] == "PrintAll")
                {
                    foreach (var item in list)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                if(line[0] == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                line = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
