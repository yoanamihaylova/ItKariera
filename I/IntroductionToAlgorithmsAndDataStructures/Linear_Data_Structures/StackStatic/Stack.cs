using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack_Static
{
    public class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;
        public ArrayStack(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
            Count = 0;
        }
        public void Push(T element)
        {
            if (Count == elements.Length) Grow();
            elements[Count++] = element;
        }
        public T Pop()
        {
            if (Count == 0) throw new InvalidOperationException();
            T element = elements[Count - 1];
            Count--;
            return element;
        }
        public T[] ToArray()
        {
            T[] copy = new T[Count];
            Array.Copy(elements, copy, Count);
            copy = copy.Reverse().ToArray();
            return copy;
        }
        private void Grow()
        {
            Array.Resize(ref elements, elements.Length * 2);
        }
    }

}
