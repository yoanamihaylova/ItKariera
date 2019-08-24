using System;
using System.Collections.Generic;
using System.Text;

namespace CountPeople
{
    class Person
    {
        private static int count = 0;
        public static int Count
        {
            get { return count; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name,int age)
        {
            Person.count++;
            this.Name = name;
            this.Age = age;
        }

        
    }
}
