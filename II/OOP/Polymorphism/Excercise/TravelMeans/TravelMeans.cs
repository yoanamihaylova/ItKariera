using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMeans
{
    class TravelMeans
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Drive(double distance)
        {
            if (FuelAmount >= fuelConsumption * distance)
            {
                FuelAmount -= fuelConsumption * distance;
                Console.WriteLine($"{this.Name} travelled {distance} km");
            }
            else Console.WriteLine($"{this.Name} needs refueling");
        }
        public void Fueling(double amount)
        {
            FuelAmount += amount;
        }

        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public TravelMeans(double fuelAmount, double fuelConsumption)
        {
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{this.Name}: {this.FuelAmount:f2}";
        }

    }
}
