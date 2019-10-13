using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        public Ram(double price) : base(price, 0.1)
        {
            this.Price = price;
            this.Weight = 0.1;
        }
    }
}
