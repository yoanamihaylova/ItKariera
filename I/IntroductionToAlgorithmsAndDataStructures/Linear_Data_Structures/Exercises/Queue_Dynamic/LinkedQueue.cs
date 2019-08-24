using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Dynamic
{
    public class LinkedQueue<T>
    {
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> tail;
        public void Enqueue(T element)
        {
            if(this.Count == 0)
            {
                this.head = this.tail = new QueueNode<T>(element);
            }
            else
            {
                var a = new QueueNode<T>(element);
                tail.nextNode = a;
                tail.prevNode = 
            }
            Count++;
        }
        public T Dequeue()
        {

        }
        public T[] ToArray()
        {
            var arr = new T[this.Count];
            int index = 0;
            QueueNode<T> currentNode = this.head;
            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.nextNode;
            }
            return arr;
        }

        
        
    }

}
