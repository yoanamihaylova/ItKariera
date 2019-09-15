using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomArrayList customArrayList = new CustomArrayList();
            var input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                customArrayList.Add(item);
            }
            Console.WriteLine(customArrayList.Count);
            Console.WriteLine(customArrayList.RandomElement());
            Console.WriteLine(customArrayList.Count);
        }
    }
}
