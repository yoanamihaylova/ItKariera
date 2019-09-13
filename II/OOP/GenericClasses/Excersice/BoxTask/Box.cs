using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxTask
{
    class Box<T>
    {
        private List<T> data;
        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }
        public Box()
        {
            Data = new List<T>();
        }
        public void Add(T element)
        {
            data.Add(element);
        }
        public T Remove()
        {
            int index = data.Count - 1;
            T element = data[data.Count - 1];

            data.RemoveAt(index);
            return element;
        }
        public override string ToString()
        {
            string result = "";
            foreach (var item in Data)
            {
                result += item.GetType().FullName + " : " + item + Environment.NewLine;
            }
            return result;
        }
    }
}
