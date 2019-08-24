using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meal
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Invalid Command!");
                // if (value == "") throw new ArgumentException("Invalid Command!");
                name = value;
            }
        }
        private string type;

        private string Type
        {
            get { return type; }
            set
            {
                if (value == "") throw new ArgumentException("Invalid Command!");
                type = value;
            }
        }
        private List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }


        public Meal(string name, string type)

        {
            this.Name = name;
            this.Type = type;
            this.products = new List<Product>();

        }
        private double price;


        public double Price
        {
            get
            {
                this.price = GetMealPrice();
                return price;
            }
            //   set { price = GetMealPrice(); }
        }

        private int ordered = 0;

        public int Ordered
        {
            get { return ordered; }
            //set { ordered = 0; }
        }


        public Meal(string name, string type, List<Product> products)

        {
            this.Name = name;
            this.Type = type;
            this.Products = products;


        }

        public double GetMealPrice()
        {
            double sum = 0;
            foreach (var item in Products)
            {
                sum += item.Price;
            }
            return sum + sum * 0.30;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Type}";
        }



        public void AddProduct(Product p)
        {

            products.Add(p);

        }

        public bool ContainsProduct(string name)
        {
            var p = products.Where(element => element.Name == name).FirstOrDefault();
            if (p == null) return false;
            else return true;

        }


        public void PrintRecipe()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine(this.Name + " RECIPE");
            Console.WriteLine(new string('-', 25));
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} - {item.Weight}");
            }
            Console.WriteLine(new string('-', 25));
        }

        public void Order()
        {
            ordered++;
        }
        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            var meal = meals.OrderByDescending(x => x.Value.ordered).FirstOrDefault().Value;
            return meal;
        }



        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            return meals.Where(x => x.Value.Price <= price).OrderByDescending(y => y.Value.Price).FirstOrDefault().Value;
        }



        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {

            return meals.Where(x => x.Value.Price <= price && x.Value.Type == type).OrderByDescending(y => y.Value.Price).FirstOrDefault().Value;

        }


    }
}

