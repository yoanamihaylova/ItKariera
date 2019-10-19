using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Entites.Tyres
{
    class HardTyre : Tyre
    {
        public HardTyre(string name, double hardness) : base("Hard", hardness)
        {
        }
    }
}
