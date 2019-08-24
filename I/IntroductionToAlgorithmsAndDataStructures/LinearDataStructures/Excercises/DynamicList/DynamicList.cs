using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public int Count { get { return count; } }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if(Count == 0)
            {
                Node node = new Node(item);
                head = node;
                tail = node;
            }
            else
            {
                Node node = new Node(item, tail);
                tail = node;
            }
            count++;
        }
        public object Remove(int index)
        {
            if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
            int currentIndex = 0;
            Node current = head, prev = null;
            while (currentIndex < index)
            {
                currentIndex++;
                prev = current;
                current = current.Next;
            }
            object element = current.Element;
            if (index == 0) head = head.Next;
            else prev.Next = current.Next;
            count--;
            return element;
        }

        public int Remove(object item) // трием по стойност , връщаме индекса на изтритата стойност и -1 ако няма такъв елемнт
        {
            Node current = head;
            int ind = 0;
            while(current != null && !current.Element.Equals(item))
            {
                current = current.Next;
                ind++;
            }
            if (current == null) return -1;
            else
            {
                Remove(ind);
                return ind;
            }
        }
        public int IndexOf(object item)
        {
            Node current = head;
            int ind = 0;
            while (current != null && !current.Element.Equals(item) )
            {
                current = current.Next;
                ind++;
            }
            if (current == null) return -1;
            else
            {
                return ind;
            }
        }

        public bool Contains(object item)
        {
            if (IndexOf(item) != -1) return true;
            else return false;
        }
        
        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                int currentIndex = 0;
                Node current = head;
                while (currentIndex < index)
                {
                    currentIndex++;
                    current = current.Next;
                }
                return current.Element;
            }
            set
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                int currentIndex = 0;
                Node current = head;
                while (currentIndex < index)
                {
                    currentIndex++;
                    current = current.Next;
                }
                current.Element = value;
            }
        }
    }
}

