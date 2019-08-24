using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Creature
    {
        private string name;
        private int years;
        private string areal;
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string value)
        {
            this.name = value;
        }
    }
}
