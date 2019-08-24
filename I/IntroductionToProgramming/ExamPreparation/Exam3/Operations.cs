using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            string operation;
            operation = Console.ReadLine();
            if (operation == "+" || operation == "-" || operation == "*")
            {
                if(operation=="+")
                {
                    if ((N1 + N2) % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even",N1,N2,N1+N2);
                    else Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, N1 + N2);
                }
                else if(operation=="-")
                {
                    if (Math.Abs(N1 - N2) % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", N1, N2, N1 - N2);
                    else Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, N1 - N2);
                }
                else
                {
                    if (Math.Abs(N1 * N2) % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even", N1, N2, N1 * N2);
                    else Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, N1 * N2);
                }
            }
            else
            {
                if (N2 == 0) Console.WriteLine("Cannot divide {0} by zero", N1);
                else if (operation == "/") Console.WriteLine("{0} / {1} = {2}", N1, N2, (double)N1 / N2);
                else Console.WriteLine("{0} % {1} = {2}", N1, N2, N1 % N2);
            }

        }
    }
}
