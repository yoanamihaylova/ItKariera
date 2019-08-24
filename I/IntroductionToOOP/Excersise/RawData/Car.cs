using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int enginespeed;

        private Engine engine;
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private Cargo cargo;

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private Tire tire1;

        public Tire Tire1
        {
            get { return tire1; }
            set { tire1 = value; }
        }
        private Tire tire2;

        public Tire Tire2
        {
            get { return tire2; }
            set { tire2 = value; }
        }

        private Tire tire3;

        public Tire Tire3
        {
            get { return tire3; }
            set { tire3 = value; }
        }

        private Tire tire4;

        public Tire Tire4
        {
            get { return tire4; }
            set { tire4 = value; }
        }



        public Car(string model,int engineSpeed,int enginePower,int cargoWeight,string cargoType,double tire1Pressure,int tire1Age,double tire2Pressure,int tire2Age,double tire3Pressure,int tire3Age,double tire4Pressure,int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tire1 = new Tire(tire1Pressure, tire1Age);
            this.Tire2 = new Tire(tire2Pressure, tire2Age);
            this.Tire3 = new Tire(tire3Pressure, tire3Age);
            this.Tire4 = new Tire(tire4Pressure, tire4Age);
            
        }
    }
}
