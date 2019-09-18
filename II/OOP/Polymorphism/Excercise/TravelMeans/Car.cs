using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMeans
{
    class Car : TravelMeans
    {
        public Car(double fuelAmount, double fuelConsumption) : base(fuelAmount, fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption + 0.9;
            this.FuelAmount = fuelAmount;
            this.Name = "Car";
        }
    }
}
