using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    class StorageMaster
    {
        private List<Product> ProductPull = new List<Product>();
        private List<Storage> StorageRegister = new List<Storage>();
        Vehicle currentVehicle;

        public string AddProduct(string type, double price)

        {

           Product product;
            if (type != "Gpu" || type != "HardDrive" || type != "Ram" || type != "SolidStateDrive")
            {
                throw new InvalidOperationException("Invalid product type!");
            }
            else
            {
                if (type == "Gpu")
                {
                    product = new Gpu(price);
                    ProductPull.Add(product);
                }
                else if (type == "HardDrive")
                {
                    product = new HardDrive(price);
                    ProductPull.Add(product);
                }
                else if (type == "Ram")
                {
                    product = new Ram(price);
                    ProductPull.Add(product);
                }
                else if (type == "SolidStateDrive")
                {
                    product = new SolidStateDrive(price);
                    ProductPull.Add(product);
                }
                return $"Added {type} to pool";
            }
            

        }

        public string RegisterStorage(string type, string name)

        {
            Storage storage;
            if (type != "AutomatedWarehouse" || type != "DistributionCenter" || type != "Warehouse")
            {
                throw new InvalidOperationException("Invalid storage type!");
            }            
            else
            {
                if (type == "AutomatedWarehouse")
                {
                    storage = new AutomatedWarehouse(name);
                    StorageRegister.Add(storage);
                }
                else if (type == "DistributionCenter")
                {
                    storage = new DistributionCenter(name);
                    StorageRegister.Add(storage);
                }
                else if (type == "Warehouse")
                {
                    storage = new Warehouse(name);
                    StorageRegister.Add(storage);
                }
                return $"Registered {name}";
            }

        }

        public string SelectVehicle(string storageName, int garageSlot)

        {
            Storage storage = StorageRegister.FirstOrDefault(x => x.Name == storageName);
            currentVehicle = storage.GetVehicle(garageSlot);
            return $"Selected {currentVehicle.GetType().Name}";
        }

        
        public string LoadVehicle(IEnumerable<string> productNames)

        {

            /* Product product;
             foreach (var item in productNames)
             {
                 product = ProductPull.FirstOrDefault(x => x.GetType().Name == item);
                 if (product == null) throw new InvalidOperationException($"{item} is out of stock!");
                 if (currentVehicle.IsFull) break;


             }*/
            throw new NotImplementedException();


        }



        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)

        {

            throw new NotImplementedException();

        }



        public string UnloadVehicle(string storageName, int garageSlot)

        {
            Storage storage = StorageRegister.FirstOrDefault(x => x.Name == storageName);
           // if (storage.IsFull) throw new InvalidOperationException("Storage is full!");
            currentVehicle = storage.GetVehicle(garageSlot);
            int unloadedProductsCount = 0;
            int productsInVehicle = currentVehicle.Trunk.Count();
            unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            //productsInVehicle -= unloadedProductsCount;
            return $"Unloaded { unloadedProductsCount}/{productsInVehicle} products at { storageName}";

        }



        public string GetStorageStatus(string storageName)

        {

            throw new NotImplementedException();

        }



        public string GetSummary()

        {

            throw new NotImplementedException();

        }
    }
}
