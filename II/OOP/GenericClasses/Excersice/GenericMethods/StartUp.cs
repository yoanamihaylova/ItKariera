using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /* int n = int.Parse(Console.ReadLine());
             List<string> boxes = new List<string>();

             for (int i = 0; i < n ; i++)
             {
                 string line = Console.ReadLine();
                 boxes.Add(line);
             }
             int []positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             StringSwapping.Swap(boxes, positions[0], positions[1]);
             foreach (var item in boxes)
             {
                 Console.WriteLine(item.GetType() + " : " + item);
             }*/
            int n = int.Parse(Console.ReadLine());
            List<string> boxes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                boxes.Add(line);
            }
            string compare = Console.ReadLine();
            Console.WriteLine(StringCounting.CountBigger(boxes, compare)); 
            

        }
    }
}
