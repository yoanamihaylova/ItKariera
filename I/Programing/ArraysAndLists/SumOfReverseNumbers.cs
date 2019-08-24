using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfReverseNumbers
{
    class SumOfReverseNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int copy;
            for (int i = 0; i < nums.Count; i++)
            {
                int num = 0;
                copy = nums[i];
                while (copy!=0)
                {
                    num = num* 10 + copy % 10;
                    copy /= 10; 
                }
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
