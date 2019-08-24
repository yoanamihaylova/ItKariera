using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxNumbers
{
    class MinMaxNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            int i = 0;
            while(nums[0]==nums[i])
            {
                Console.Write(nums[i] + " ");
                i++;
            }
            i = nums.Count - 1;
            while (nums[nums.Count - 1] == nums[i])
            {
                Console.Write(nums[i]+ " ");
                i--;
            }
            Console.WriteLine();
        }
    }
}
