using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSame
{
    class LongestSame
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nums = new List<int>();
            int longestLenght = 1, currentLenght = 1, longestIndex = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1]) currentLenght++;
                else
                {
                    if(currentLenght>longestLenght)
                    {
                        longestLenght = currentLenght;
                        longestIndex = currentLenght - 1;
                    }
                }
            }
            if (currentLenght > longestLenght)
            {
                longestLenght = currentLenght;
                longestIndex = currentLenght - 1;
            }
            for (int i = 0; i < longestLenght; i++)
            {
                Console.Write(longestIndex + " ");
            }
            Console.WriteLine();
        }
    }
}
