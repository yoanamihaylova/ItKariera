using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string []line = Console.ReadLine().Split(' ').ToArray();
            foreach (var item in line)
            {
                stack.Push(item);
            }
            Console.WriteLine(stack);
            while(stack.IsEmpty()!=true)
            {
                stack.Pop();
            }
            
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
