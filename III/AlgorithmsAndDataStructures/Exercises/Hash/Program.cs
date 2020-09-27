using System;

namespace Hash
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person person = new Person("Pesho", "Peshev", 12);
            Console.WriteLine(person.GetHashCode());
        }
    }
}
