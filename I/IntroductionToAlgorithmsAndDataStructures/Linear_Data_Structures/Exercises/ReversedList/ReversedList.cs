using System;
using System.Collections.Generic;
using System.Text;

namespace ReversedList
{
    public class ReversedList<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;
        public ReversedList()
        {
            this.items = new T[InitialCapacity];
            Count = 0;
        }
        public int Count { get; private set; }
        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                return this.items[index];
            }
            set
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (this.Count == this.items.Length) this.Resize();
            this.items[Count] = item;
            this.Count++;
        }
        private void Resize()
        {
            T[] newArray = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                newArray[i] = this.items[i];
            }
            this.items = newArray;
        }
        public T RemoveAt(int index)
        {
            if (index >= this.Count) throw new ArgumentOutOfRangeException();
            T element = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4) this.Shrink();
            return element;
        }

        private void Shrink()
        {
            T[] newArray = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.items[i];
            }
            this.items = newArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
    }
}
