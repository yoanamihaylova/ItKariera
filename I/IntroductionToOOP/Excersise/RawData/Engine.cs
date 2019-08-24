using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public Engine(int spped,int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

    }
}
