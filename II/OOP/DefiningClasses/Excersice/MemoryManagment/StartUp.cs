using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagment
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Peoples list = new Peoples();
            list.Add(new Person("Anna", 17));
            list.Add(new Person("Didi", 16));
            list.Add(new Person("Bobi", 19));
            Console.WriteLine("Peoples Count = {0}",list.peoples.Count);

            list.Dispose();
        }
    }
}
