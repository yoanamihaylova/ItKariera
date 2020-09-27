using System;
using System.Collections.Generic;
using System.Text;

namespace Hash
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public override int GetHashCode()
        {
            int a = firstName.GetHashCode() + age;
            int b = lastName.GetHashCode() + age;
            return a + b;
        }
    }
}
