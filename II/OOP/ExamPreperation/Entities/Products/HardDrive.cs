using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        public HardDrive(double price) : base(price, 1)
        {
            this.Price = price;
            this.Weight = 1;
        }
    }
}
