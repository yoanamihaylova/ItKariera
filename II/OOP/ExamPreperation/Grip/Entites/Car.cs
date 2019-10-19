using GRID.Entites.Tyres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Entites
{
    public class Car
    {
        private int hp;

        public int Hp
        {
            get { return hp; }
            private set {if(value<160) hp = value;
                if (value < 0) throw new ArgumentException();
            }
        }
        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
           private set { fuelAmount = value; }
        }
        private Tyre tyre;

        public Tyre Tyre
        {
            get { return tyre; }
            private set { tyre = value; }
        }


    }
}
