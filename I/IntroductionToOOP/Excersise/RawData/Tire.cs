using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Tire(double pressure,int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

    }
}
