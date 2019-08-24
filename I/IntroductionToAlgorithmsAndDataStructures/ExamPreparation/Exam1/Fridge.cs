using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge() { }

        public int Count
        {
            get;
            set;
        }

        public void AddProduct(string ProductName)
        {
            head.Name = ProductName;
            head.Next = tail;
            tail = tail.Next;
        }

        public string[] CookMeal(int start, int end)
        {
            // TODO: Добавете вашия код тук …
        }

        public string RemoveProductByIndex(int index)
        {
            // TODO: Добавете вашия код тук …
        }

        public string RemoveProductByName(string name)
        {
            // TODO: Добавете вашия код тук …
        }

        public bool CheckProductIsInStock(string name)
        {
            // TODO: Добавете вашия код тук …
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            // TODO: Добавете вашия код тук …
        }

    }
}