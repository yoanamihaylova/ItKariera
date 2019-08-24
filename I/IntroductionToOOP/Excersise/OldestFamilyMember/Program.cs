using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family myFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                Person p = new Person();
                p.Name = input[0];
                p.Age = int.Parse(input[1]);
                myFamily.AddMember(p);
            }
            Person oldest = myFamily.GetOldestMemeber();
            Console.WriteLine(oldest.Name+" "+oldest.Age);
        }
    }
}
