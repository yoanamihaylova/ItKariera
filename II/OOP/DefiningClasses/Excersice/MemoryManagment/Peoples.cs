using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagment
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class Peoples : IDisposable
    {
        public List<Person> peoples;
        public void Add(Person person)
        {
            peoples.Add(person);
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose...");
            this.peoples = null;
        }
        public Peoples()
        {
            peoples = new List<Person>(); //heap
            Console.WriteLine("Using constructor...");
        }
        ~Peoples()
        {
            Console.WriteLine("Using destructor...");
        }
    }
}
