﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class DistributionCenter : Storage
    {
        public DistributionCenter(string name) :  base(name, 2, 5, new Vehicle[] { new Van(), new Van(), new Van() })
        {
        }
    }
}
