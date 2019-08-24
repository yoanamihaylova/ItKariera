using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace TrainsSkeleton
{
    public class Deque<T> 
    {
        private T[] arr;
        private const int defaultCapacity = 16;
        public int Capacity; 
        public int Count; 
        public Deque() : this(defaultCapacity)
        {
            arr = new T[defaultCapacity];
            Capacity = defaultCapacity;
            //Count = 0;
        }

        public Deque(int capacity)
        {
            arr = new T[capacity];
            Capacity = capacity;

        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            arr = collection.ToArray();
            Capacity = collection.Count();
            Count = collection.Count();
        }


        public void AddFront(T item)
        {

            if (Count == Capacity) Resize();
            for (int i = Count; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = item;
            Count++;

        }

        private void Resize()
        {
            Array.Resize(ref arr,2*Capacity);
            Capacity *=2;
        }

        public void AddBack(T item)
        {

            if (Count == Capacity) Resize();
            arr[Count] = item;
            Count++;

        }

        public T RemoveFront()
        {

            T item = arr[0];            
            for (int i = 0; i < Count-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Count--;
            return item;

        }

        public T RemoveBack()
        {
            T item = arr[Count-1];
            Count--;
            return item;
        }

        public T GetFront()
        {

            return arr[0];

        }

        public T GetBack()
        {
            //бройката на елементите с какво е различна от arr.lenght() ? 
            return arr[Count - 1];

        }

    }
}
