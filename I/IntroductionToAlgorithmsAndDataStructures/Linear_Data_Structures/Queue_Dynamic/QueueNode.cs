using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Dynamic
{
    public class QueueNode<T>
    {
      
        public T Value
        {
            get;
            private set;
        }

        public QueueNode<T> nextNode
        {
            get;
            set;
        }

        public QueueNode<T> prevNode
        {
            get;
            set;
        }

        public QueueNode(T value)
        {
            this.Value = value;
        }
       
    }
}
