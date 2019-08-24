using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Test2
    {
        static void Main(string[] args)
        {
            /*int n;
            List<int> list = new List<int>();
            n = list.Count;
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }*/
            List<string> items = Console.ReadLine().Split(' ').ToList();
            List<int> nums = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }
            Console.WriteLine(String.Join(" ", nums));
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
