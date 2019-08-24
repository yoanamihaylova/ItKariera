using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDemo1
{
    class DiceDemo1
    {
        static void Main(string[] args)
        {
            Dice diceD6 = new Dice();
            Dice diceD10 = new Dice();
            diceD6.sides = 6;
            diceD10.sides = 10;
            Console.WriteLine(diceD10.Roll());
        }
    }

}
