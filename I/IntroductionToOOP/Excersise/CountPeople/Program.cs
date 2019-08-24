using System;

namespace CountPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person p1 = new Person(name, age);
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Person p2 = new Person(name, age);
            Console.WriteLine(Person.Count);
            Console.WriteLine(p2.Age);
        }
    }
}
