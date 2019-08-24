using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot be less than 3 symbols");
                else firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot be less than 3 symbols");
                else lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0) throw new ArgumentException("Age cannot be zero or negative integer");
                else age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Age} get {this.Salary:f2} leva";
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 460) throw new ArgumentException("Salary cannot be less than 460 leva");
                salary = value;
            }
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;

        }
        public void IncreasesSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }

    }
}
