using System;
using System.Linq;

namespace SumZero
{
    class SumZero
    {
        static int[] perm;
        static int[] input;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            perm = new int[n];
            Gen(0);
        }
        static void Gen(int index)
        {
            if (index == perm.Length) Print();
            else
                for (int i = 0; i < 2; i++)
                {
                    perm[index] = i;
                    Gen(index + 1);
                }
        }
        static void Print()
        {
            int sum = 0;           
  
            for (int i = 0; i < perm.Length; i++)
            {
                if (perm[i] == 0) sum += input[i];
                else sum -= input[i];

            }          
           if(sum == 0)
            {
                for (int i = 0; i < perm.Length; i++)
                {
                    if (perm[i] == 0) Console.Write("+");
                    else Console.Write("-");
                    Console.Write(input[i] + " ");
                }
                Console.WriteLine("= " + sum);
            }

        }
    }
}
