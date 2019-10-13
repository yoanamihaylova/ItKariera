using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{ 
    public class SolidStateDrive : Product
{
    public SolidStateDrive(double price) : base(price, 0.2)
    {
        this.Price = price;
        this.Weight = 0.2;
    }
}
}
