using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class ListNode<T>
    {
        public T Value
        {
            get;
            private set;
        }

        public ListNode<T> nextNode
        {
            get;
            set;
        }

        public ListNode<T> prevNode
        {
            get;
            set;
        }

        public ListNode(T value)
        {
            this.Value = value;
        }
    }
}