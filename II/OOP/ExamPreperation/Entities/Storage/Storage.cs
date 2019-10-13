using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Storage
{
    abstract public class Storage
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private int garageSlots;

        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }
        private bool isFull;

        public bool IsFull
        {
            get
            {

                double sum = 0;
                foreach (var item in products)
                {
                    sum += item.Weight;
                }
                if (sum >= Capacity) return true;
                else return false;
            }
        }


        readonly Vehicle[] vehicles;

        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return vehicles; }
        }
        readonly List<Product> products;

        public IReadOnlyCollection<Product> Products
        {
            get { return products; }
        }
        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.products = new List<Product>();
            this.vehicles = new Vehicle[GarageSlots];
            int i = 0;
            foreach (var item in vehicles)
            {
                this.vehicles[i] = item;
                i++;
            }
        }
        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (vehicles[garageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");
            return vehicles[garageSlot];
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);
            int slotToMove = EmptySlot(deliveryLocation);
            if (slotToMove == -1) throw new InvalidOperationException("No room in garage!");
            deliveryLocation.vehicles[slotToMove] = vehicle;
            this.vehicles[garageSlot] = null;
            return slotToMove;

        }
        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull == true)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = GetVehicle(garageSlot);
            int count = 0;
            while (!vehicle.IsEmpty && !IsFull)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                count++;
            }
            return count;


        }
        private int EmptySlot(Storage storage)
        {
            for (int i = 0; i < storage.vehicles.Length; i++)
            {
                if (storage.vehicles[i] == null) return i;

            }
            return -1;
        }

    }
}
