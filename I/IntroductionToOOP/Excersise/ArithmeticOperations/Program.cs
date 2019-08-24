using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Arithmetic.Add(num1,num2));
            Console.WriteLine(Arithmetic.Multiply(num1,num2));
        }
    }
}
