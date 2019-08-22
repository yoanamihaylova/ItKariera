using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Text_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", first_name, last_name, age, town);

        }
    }
}
