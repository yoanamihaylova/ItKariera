using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCompare
{
    class Cat : IComparable<Cat>
    {
        public string Name { get; set; }
        public int CompareTo(Cat other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public Cat(string name)
        {
            this.Name = name;
        }
    }
}
