using System;
using System.Collections.Generic;
using System.Text;

namespace TrainsSkeleton
{
    class Train
    {
        public int Number { get; set; }
        public int Cars { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }
        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
