using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Insert
{
    class Method_Insert
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int[] copy = new int [numbers.Length+1];
            int i;
            for (i = 0; i < numbers.Length && numbers[i]<num; i++)
            {
                copy[i] = numbers[i];
            }
            copy[i] = num;
            for(int j = i+1; j<=numbers.Length;j++) copy[j] = numbers[j-1];
            for ( i = 0; i < copy.Length; i++) Console.Write(copy[i]+" ");    
        }
    }
}
