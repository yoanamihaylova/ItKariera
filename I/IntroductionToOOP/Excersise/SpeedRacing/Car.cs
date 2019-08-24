using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
   public class Car
   {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private double fuelamount;

        public double FuelAmount
        {
            get { return fuelamount; }
            set { fuelamount = value; }
        }
        private double consumption;

        public double Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }
        private int traveleddistance;

        public int TraveledDistance
        {
            get { return traveleddistance; }
            set { traveleddistance = value; }
        }
       /* private int amountKilometers;

        public int AmountKilometers
        {
            get { return amountKilometers; }
            set { amountKilometers = value; }
        }*/

        public Car(string model,double fuelamount,double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelamount;
            this.Consumption = consumption;
        }

        public void Calculate(int amountkilometers)
        {
            if (this.FuelAmount - amountkilometers * this.Consumption >= 0)
            {
                this.FuelAmount -= amountkilometers * this.Consumption;
                this.TraveledDistance += amountkilometers;
            }
            else Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
