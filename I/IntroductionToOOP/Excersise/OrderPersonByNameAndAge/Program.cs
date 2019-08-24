using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPersonByNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var person = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                Person p = new Person(input[0],input[1],int.Parse(input[2]),decimal.Parse(input[3]));
                person.Add(p);
            }
            decimal percentage = decimal.Parse(Console.ReadLine());
            foreach (var item in person)
            {
                item.IncreasesSalary(percentage);
            }
            person.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
