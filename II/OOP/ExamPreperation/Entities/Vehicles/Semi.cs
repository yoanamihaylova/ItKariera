using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Vehicles
{
    public class Semi : Vehicle
    {
        public Semi() : base(10)
        {
            this.Capacity = 10;
        }
    }
}
