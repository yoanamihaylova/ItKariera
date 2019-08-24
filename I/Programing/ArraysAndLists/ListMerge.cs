using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split('|').ToList();
            names.Reverse();
            for(int i=0;i<names.Count;i++)
            {
                Console.Write(names[i]+" ");
            }
            List<int> nums = new List<int>();
            for (int i = 0; i < names.Count; i++)
            {
                var temp = names[i].Split(' ').ToList();
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j] != "") nums.Add(int.Parse(temp[j]));
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i]+" ");
            }
        }
    }
}
