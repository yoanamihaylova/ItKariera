using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsANumberContaintedInArray
{
    class IsNumberontainrdInArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num) { Console.WriteLine("{0} Exists in the List", num); flag = true; break; }
             
            }   if(flag == false ) Console.WriteLine("{0} Not exists in the List", num);
            
        }
    }
}
