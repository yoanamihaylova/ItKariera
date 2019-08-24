using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char temp;
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - 1 - i] = temp;
            }
            for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i] + " ");
        }
    }
}
