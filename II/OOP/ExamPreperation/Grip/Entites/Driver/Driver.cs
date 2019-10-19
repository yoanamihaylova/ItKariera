using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Entites.Driver
{
    class Driver
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double totalTime;

        public double TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        private double speed;

        public double Speed
        {
            // Скоростта на шофьора се изчислява по формулата по-долу.Имайте предвид, че скоростта се променя на всяка обиколка.
            get
            {
                speed = (car.Hp + car.Tyre.Degradation) / car.FuelAmount;
                return speed;
            }
        }
        private double fuelConsumptionPerkm;

        public double FuelConsumptionPerKm
        {
            get { return fuelConsumptionPerkm; }
            set { fuelConsumptionPerkm = value; }
        }


    }
}
