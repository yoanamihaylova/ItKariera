using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Test1
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Maria");
            names.Add("Ivanka");
            names.Add("Didi");
            foreach (var a in names)
            {
                Console.Write(a + ' ');
            }
            Console.WriteLine( );
            names.Remove("Ivanka");
            Console.WriteLine(String.Join(" ",names));
            names.Add("Marina");
            Console.Write("After Add: ");
            foreach (var a in names)
            {
                Console.Write(a + ' ');
            }
            Console.WriteLine();
            names.RemoveAt(2);
            Console.Write("After Remove at 2: ");
            foreach (var a in names)
            {
                Console.Write(a + ' ');
            }
            Console.WriteLine();
            names.Insert(0, "Reni");
            Console.Write("After Insert at 0: ");
            foreach (var a in names)
            {
                Console.Write(a + ' ');
            }
            Console.WriteLine();
            Console.WriteLine(names.Count);
        }
    }
}
