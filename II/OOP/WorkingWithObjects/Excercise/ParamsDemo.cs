using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class ParamsDemo
    {
        static void Main(string[] args)
        {
            PrintNames("Pesho", "Stamat", "Jivko", "Stavri");
            
        }

        public static void PrintNames(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
