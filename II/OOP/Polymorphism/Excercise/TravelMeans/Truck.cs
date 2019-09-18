using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMeans
{
    class Truck : TravelMeans
    {
        public Truck(double fuelAmount, double fuelConsumption) : base(fuelAmount, fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption + 1.6;
            this.FuelAmount = fuelAmount;
            this.Name = "Truck";
        }
      
    }
}
