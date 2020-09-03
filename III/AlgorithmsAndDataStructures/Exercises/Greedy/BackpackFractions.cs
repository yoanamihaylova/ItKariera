using System;
using System.Collections.Generic;
using System.Linq;

namespace BackpackFractions
{
    class Item
    {
        public double Price { get; set; }
        public double Weight { get; set; }
    }
    class BackpackFractions
    {
        static void Main(string[] args)
        {
            var Capacity = double.Parse(Console.ReadLine().Split()[1]);
            var Items = double.Parse(Console.ReadLine().Split()[1]);
            var allItems = new List<Item>();
            for (int i = 0; i < Items; i++)
            {
                var currentItem = Console.ReadLine().Split();
                allItems.Add(new Item
                {
                    Weight = double.Parse(currentItem[2]), 
                    Price = double.Parse(currentItem[0])
                });
            }
            allItems = allItems.OrderByDescending(i => i.Price / i.Weight).ToList();

            int index = 0;
            double totalPrice = 0;

            while (Capacity > 0 && index < allItems.Count)
            {
                var currentItem = allItems[index];
                var takenQuantity = Math.Min(Capacity, currentItem.Weight);
                var percentQuantity = takenQuantity / currentItem.Weight;

                Capacity -= takenQuantity;
                totalPrice += percentQuantity * currentItem.Price;

                var percQualityAsString = percentQuantity == 1 ? "100" : $"{percentQuantity * 100:F2}";
                Console.WriteLine($"Take {percQualityAsString}% of item with price {currentItem.Price}");
                index++;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
