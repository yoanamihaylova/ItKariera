using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxTask
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(3);
            box.Add(4);
            box.Add(6);
            Console.WriteLine(string.Join(" ",box.Data));
            box.Remove();
            Console.WriteLine(string.Join(" ", box.Data));
        }
    }
}
