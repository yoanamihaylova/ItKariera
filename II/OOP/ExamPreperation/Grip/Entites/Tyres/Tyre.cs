using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Entites.Tyres
{
    abstract public class Tyre
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double hardness;

        public double Hardness
        {
            get { return hardness; }
            set { hardness = value; }
        }
        private double degradation;

        public double Degradation
        {
            get { return degradation; }
            set {if (degradation < 0) throw new ArgumentException();
                degradation = value; }
        }
        public Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Degradation = 100;
            this.Hardness = hardness;
        }

    }
}
