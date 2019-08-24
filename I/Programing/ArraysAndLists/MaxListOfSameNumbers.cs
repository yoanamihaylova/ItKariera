using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxListOfSameNumbers
{
    class MaxListOfSameNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int br = 1;
            int brmax = 1;
            int num = nums[0];
            for(int i=0;i<nums.Count-1;i++)
            {
                if (nums[i] == nums[i + 1]) br++;

                else
                {
                    if (br > brmax)
                    {
                        brmax = br;
                        num = nums[i];
                    }
                 br = 1;
                }   
            }
            if (br > brmax)
            {
                brmax = br;
                num = nums[nums.Count - 1];
            }
            for (int i = 0; i < brmax; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
