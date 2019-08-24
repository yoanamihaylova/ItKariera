using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInSortedArray
{
    class SearchInSortedArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int l, r, mid;
            l = 0;
            r = numbers.Length - 1;
            while (l<=r)
            {
                mid = (l + r) / 2;
                if(numbers[mid]==num)
                {
                    Console.WriteLine("{0} Exists in the List",num);
                    return;
                }
                if (numbers[mid] < num) l = mid + 1;
                else r = mid - 1;
            }
            Console.WriteLine("{0} Not exists in the List",num);
        }
    } 
}
 

