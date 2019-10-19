using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Entites.Tyres 
{
    class UltrasoftTyre : Tyre
    {
        public UltrasoftTyre(string name, double hardness) : base("Ultrasoft", hardness)
        {
        }
        private double grip;

        public double Grip
        {
            get { return grip; }
            set { grip = value; }
        }

    }
}
