using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        private List<T> list ;

        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }

        public CustomList()
        {
            this.List = new List<T>();
        }
        public void Add(T element)
        {
            List.Add(element);
        }
	    public T Remove(int index)
        {
            T temp = list[index];
            list.RemoveAt(index);
            return temp;            
        }
	    public  bool Contains(T element)
        {
            foreach (var item in list)
            {
                if (item.Equals(element)) return true;
            }
            return false;
        }
	    public void Swap(int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
	    public int CountGreaterThan(T element)
        {
            int br = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0) br++;
            }
            return br;
        }
        public T Max()
        {
            return list.Max();
        }
	    public T Min()
        {
            return list.Min();
        }
        public override string ToString()
        {
            string temp = "";
            foreach (var item in list)
            {
                temp += $"{item}";
            }
            return temp;
        }
    }
}
