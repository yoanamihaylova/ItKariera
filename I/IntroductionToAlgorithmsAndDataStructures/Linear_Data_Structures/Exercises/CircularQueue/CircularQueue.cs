using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Properties
{
    public class CircularQueue<T>
    {
        private T[] elements;
        private int sartIndeks = 0;
        private int endIndeks = 0;
        private const int DefaultCapacity = 4;
        public int Count { get; private set; }

        public CircularQueue(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (Count >= elements.Length)
            {
                Grow();
            }
            elements[endIndeks] = element;
            endIndeks = (endIndeks + 1) % elements.Length;
            Count++;
        }

        private void Grow()
        {
            var newElements = new T[2 * elements.Length];
            CopyAllElements(newElements);
            elements = newElements;
            sartIndeks = 0;
            endIndeks = Count;
        }

        private void CopyAllElements(T[] resultArr)
        {
            int sourceIndeks = sartIndeks;
            int destinationIndeks = 0;
            for (int i = 0; i < Count; i++)
            {
                resultArr[destinationIndeks] = elements[sourceIndeks];
                sourceIndeks = (sourceIndeks + 1) % elements.Length;
                destinationIndeks++;
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var result = elements[sartIndeks];
            sartIndeks = (sartIndeks + 1) % elements.Length;
            Count--;
            return result;
        }
        public T[] ToArray()
        {
            var resultArr = new T[Count];
            CopyAllElements(resultArr);
            return resultArr;
        }

    }
}