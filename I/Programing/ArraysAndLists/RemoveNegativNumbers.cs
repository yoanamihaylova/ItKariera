using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                }
            }
            for (int j = 0; j < nums.Count; j++)
            {
                Console.Write(nums[j] + " ");
            }

        }
    }
}
