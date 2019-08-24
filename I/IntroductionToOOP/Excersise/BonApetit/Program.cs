﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Program
    {

        private static Dictionary<string, Product> products = new Dictionary<string, Product>();
        private static Dictionary<string, Meal> meals = new Dictionary<string, Meal>();

        private static void AddProduct(string name, double price, int weight)
        {
            try
            {
                products.Add(name, new Product(name, price, weight));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddMultiProduct(int productsCount)
        {
            for (int i = 0; i < productsCount; i++)
            {
                string[] productData = Console.ReadLine().Split(' ').ToArray();
                try
                {
                    products.Add(productData[0], new Product(productData[0], double.Parse(productData[1]), int.Parse(productData[2])));

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void AddMeal(string name, string type)
        {
            try
            {
                meals.Add(name, new Meal(name, type));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddMealProducts(string name, string type, int productsCount)
        {
            List<Product> mealProducts = new List<Product>();
            string[] productData = Console.ReadLine().Split(' ').ToArray();
            foreach (var product in productData)
            {
                mealProducts.Add(products[product]);
            }
            // 			}

            try
            {
                meals.Add(name, new Meal(name, type, mealProducts));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddProductToMeal(string productName, string mealName)
        {
            if (meals[mealName].GetType().GetMethod("AddProduct") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("AddProduct");
                method.Invoke(meals[mealName], new[] { products[productName] });
                //old call: meals[mealName].AddProduct(products[productName]);
            }
        }

        private static void ContainsProduct(string productName, string mealName)
        {
            if (meals[mealName].GetType().GetMethod("ContainsProduct") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("ContainsProduct");
                bool result = (bool)method.Invoke(meals[mealName], new[] { productName });

                if (result)
                {
                    Console.WriteLine("{0} is contained in {1}.",
                        productName,
                        mealName);
                }
                else
                {
                    Console.WriteLine("{0} is NOT contained in {1}.",
                        productName,
                        mealName);
                }
            }

        }

        private static void GetMealPrice(string mealName)
        {
            if (meals[mealName].GetType().GetProperty("Price") != null)
            {
                Console.WriteLine("The price of {0} is: {1:0.00}", mealName, Math.Round((double)meals[mealName].GetType().GetProperty("Price").GetValue(meals[mealName]), 2));
            }
        }

        private static void PrintMealRecipe(string mealName)
        {
            if (meals[mealName].GetType().GetMethod("PrintRecipe") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("PrintRecipe");
                method.Invoke(meals[mealName], null);
                //  old call:                meals[mealName].PrintRecipe();
            }
        }

        private static void OrderMeal(string mealName)
        {
            if (meals[mealName].GetType().GetMethod("Order") != null)
            {
                MethodInfo method = meals[mealName].GetType().GetMethod("Order");
                method.Invoke(meals[mealName], null);
            }

        }

        private static void GetSpecialty()
        {

            MethodInfo method = typeof(Meal).GetMethod("GetSpecialty");
            Meal specialty = (Meal)method.Invoke(null, new[] { meals });

            Console.WriteLine("The current specialty is: {0}", specialty.Name);
        }

        private static void RecommendByPrice(double price)
        {
            MethodInfo method = typeof(Meal).GetMethod("RecommendByPrice");
            Meal recommendation = (Meal)method.Invoke(null, new object[] { price, meals });

            Console.WriteLine("The recommended meal for {0} is {1}. It costs {2:0.00}",
                price,
                recommendation.Name,
                Math.Round(recommendation.Price, 2));
        }
        private static void RecommendByPriceAndType(double price, string type)
        {
            MethodInfo method = typeof(Meal).GetMethod("RecommendByPriceAndType");
            Meal recommendation = (Meal)method.Invoke(null, new object[] { price, type, meals });

            Console.WriteLine("The recommended meal for {0} of type {1} is {2}. It costs {3:0.00}",
                price,
                type,
                recommendation.Name,
                Math.Round(recommendation.Price, 2));
        }

        private static void GetCheapestProduct()
        {
            MethodInfo method = typeof(Product).GetMethod("GetCheapestProduct");
            Product cheapest = (Product)method.Invoke(null, new object[] { products });

            Console.WriteLine("The cheapest product is {0}.", cheapest.Name);
        }

        public static void Main(string[] args)
        {

            string command = "";
            do
            {
                command = Console.ReadLine();
                string[] commandData = command.Split(' ').ToArray();

                switch (commandData[0])
                {
                    case "AddProduct":
                        AddProduct(commandData[1], double.Parse(commandData[2]), int.Parse(commandData[3]));
                        break;
                    case "AddMultiProducts":
                        AddMultiProduct(int.Parse(commandData[1]));
                        break;
                    case "AddMeal":
                        AddMeal(commandData[1], commandData[2]);
                        break;
                    case "AddMealProducts":
                        AddMealProducts(commandData[1], commandData[2], int.Parse(commandData[3]));
                        break;
                    case "AddProductToMeal":
                        AddProductToMeal(commandData[1], commandData[2]); // <Product> <Meal>
                        break;
                    case "ContainsProduct":
                        ContainsProduct(commandData[1], commandData[2]); // <Product> <Meal>
                        break;
                    case "GetMealPrice":
                        GetMealPrice(commandData[1]);
                        break;
                    case "PrintMealRecipe":
                        PrintMealRecipe(commandData[1]);
                        break;
                    case "OrderMeal":
                        OrderMeal(commandData[1]);
                        break;
                    case "GetSpecialty":
                        GetSpecialty();
                        break;
                    case "RecommendByPrice":
                        RecommendByPrice(double.Parse(commandData[1]));
                        break;
                    case "RecommendByPriceAndType":
                        RecommendByPriceAndType(double.Parse(commandData[1]), commandData[2]);
                        break;
                    case "Cheapest":
                        GetCheapestProduct();
                        break;
                    case "PrintProduct":
                        Console.WriteLine(products[commandData[1]]);
                        break;
                    case "PrintMeal":
                        Console.WriteLine(meals[commandData[1]]);
                        break;
                }


            } while (command != "End");
            /*Команди:
			 * Add Product; name, price, weight
			 * Add Products (multiple), as above, splitted by |
			 * Add Meal - name, type
			 * Add Meal with products - name, type, products on second line, splitted by |
			 * Add Product to Meal
			 * Check if meal contains product
			 * Get meal price 
			 * Print Meal recipe
			 * Order meal
			 * Get specialty
			 * Recommend by price
			 * Recommend by price and type
			 * Get cheapest product
			 * Get most used product
			 * 
			 * Разбиване по тестове:
			 * 1-3 тест: 1 команда, 3 команда, 5 команда, 7 команда
			 * 4 тест: 1-3-5-7 + 2 команда+4 команда +6 команда+8 команда
			 * 5 тест: 1-10 команда
			 * 6 тест: до рекоменд
			 * 7 тест: до двата рекоменда
			 * 8 тест: най-евтин продукт
			 * 9 тест: най-ползван продукт
			 * 10 тест: валидация
			 * 11-13 тест: като 1-3, но с валидация
			 * 14 тест - като 4 с валидация
			 * 15 тест - като 5 с валидация
			 * 16 тест - като 6 с валидация
			 * 17 тест - като 7 с валидация
			 * 18 тест - като 8 с валидация
			 * 19 тест - като 9 с валидация
			 * 20 тест - като 10 с валидация
			Console.WriteLine ("Hello World!");*/
        }
    }
}
