using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { if (value.Length < 3) throw new ArgumentException("Invalid Command!");
                name = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { if (value < 0.01) throw new ArgumentException("Invalid Command!");
                    price = value; }
        }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { if (value <= 0) throw new ArgumentException("Invalid Command!");
                weight = value; }
        }

        public Product(string name, double price, int weight)

        {

            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Weight}";
        }

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            var product = products.OrderBy(x => x.Value.Price).First().Value;
            return product;
        }

    }

}

/*
 * AddProduct testo 1,50 100
PrintProduct testo
AddProduct meso 2,00 200
PrintProduct meso
AddMeal pizza pizza
PrintMeal pizza
AddMultiProducts 6
domatenSos 0,50 1
domatki 0,60 5
kashkaval 0,80 5
domati 0,60 5
krastavici 0,30 3
zele 0,70 1
PrintProduct domatki
AddProductToMeal testo pizza
AddProductToMeal domatenSos pizza
AddProductToMeal domatki pizza
AddProductToMeal meso pizza
AddProductToMeal kashkaval pizza
ContainsProduct pesto pizza
GetMealPrice pizza
PrintMealRecipe pizza
Cheapest
OrderMeal pizza
AddMeal pArl3nka pizza
AddProductToMeal testo pArl3nka
AddProductToMeal kashkaval pArl3nka
PrintMeal pArl3nka
AddMealProducts salata salati 3
domati krastavici zele
PrintMeal salata
ContainsProduct testo salata
ContainsProduct testo pizza
GetMealPrice salata
OrderMeal pizza
OrderMeal salata
GetSpecialty
RecommendByPrice 5
RecommendByPriceAndType 8 pizza
End*/

