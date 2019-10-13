using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    public abstract class Product
    {
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new InvalidOperationException("Price cannot be negative!");
                else price = value;
            }
        }
        public double Weight { get; set; }
        public Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

    }
}
