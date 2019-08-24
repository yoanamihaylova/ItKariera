using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDemo1
{
    class Dice
    {
        public int sides;
        //string type;
        private Random rnd = new Random();
        public int Roll()
        {
            int result = rnd.Next(1, this.sides + 1);
            return result;
        }
    }
}
