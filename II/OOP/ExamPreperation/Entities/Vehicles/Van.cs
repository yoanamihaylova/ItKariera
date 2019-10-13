using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Vehicles
{
    public class Van : Vehicle
    {
        public Van() : base(2)
        {
            this.Capacity = 2;
        }
    }
}
