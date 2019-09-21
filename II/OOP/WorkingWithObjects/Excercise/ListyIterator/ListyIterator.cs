using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator <T> : IEnumerable<T>
    {
        private List<T> listy;
        private int index = 0;
        public ListyIterator(params T []listy)
        {
            this.Create(listy);
        }

        public void Create(params T[] listy)
        {
            this.listy = new List<T>(listy);
        }
        public bool Move()
        {
            if (!HasNext()) return false;
            else
            {
                this.index++;
                return true;
            }
        }
        public bool HasNext()
        {
            if (this.index == this.listy.Count - 1) return false;
            else return true;
        }
        public void Print()
        {
            if (this.listy.Count == 0) throw new Exception("Invalid Operation");
            else Console.WriteLine(this.listy[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in listy)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
       /* public void PrintAll()
        {
            foreach (var item in listy)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }*/
    }
}
