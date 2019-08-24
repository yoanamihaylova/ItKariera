using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Cargo(int weight,string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

    }
}
