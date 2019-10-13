using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        List<Product> trunk = new List<Product>();
        public IReadOnlyCollection<Product> Trunk
        {
            get { return trunk; }
        }
        private bool isFull;

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                double sum = 0;
                foreach (var item in trunk)
                {
                    sum += item.Weight;
                }
                if (sum >= Capacity) isFull = true;
                else isFull = false;
            }
        }
        /* private bool isEmpty;

         public bool IsEmpty
         {
             get { return isEmpty; }
             set
             {
                 double sum = 0;
                 foreach (var item in trunk)
                 {
                     sum += item.Weight;
                 }
                 if (sum == 0) isEmpty = true;
                 else isEmpty = false;
             }
         }*/
        public bool IsEmpty => trunk.Count == 0;

        /*
         * public bool IsFull => trunk.Sum(x => x.Weight) >= Capacity;
         * public bool IsEmpty => trunk.Count == 0;
         */
        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            trunk = new List<Product>();
        }
        public void LoadProduct(Product product)
        {
            if (IsFull == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            else trunk.Add(product);
        }
        public Product Unload()
        {
            if (IsEmpty == true)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            Product last = trunk[trunk.Count - 1];
            trunk.RemoveAt(trunk.Count - 1);
            return last;
        }
    }
}
