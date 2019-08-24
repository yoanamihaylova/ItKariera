using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNameList
{
    class ReverseNameList
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i]+';');
            }
            Console.WriteLine();
        }
    }
}
