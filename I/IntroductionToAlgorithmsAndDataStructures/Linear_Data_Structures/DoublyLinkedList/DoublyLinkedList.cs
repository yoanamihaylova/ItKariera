using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class DoublyLinkedList<T>
    {

            private ListNode<T> head;
            private ListNode<T> tail;
            public int Count
            {
                get;
                private set;
            }
            public void AddFirst(T element)
            {
                if(this.Count == 0)
                {
                    this.head = this.tail = new ListNode<T>(element);
                }
                else
                {
                    var newHead = new ListNode<T>(element);
                    newHead.nextNode = this.head;
                    this.head.prevNode = newHead;
                    this.head = newHead;
                }
                this.Count++;
            }
            public void ForEach(Action<T> action)
            {
                var currentNode = this.head;
                while(currentNode != null)
                {
                    action(currentNode.Value);
                    currentNode = currentNode.nextNode;
                }
            }
            public void AddLast(T element)
            {
                if (this.Count == 0)
                {
                    this.head = this.tail = new ListNode<T>(element);
                }
                else
                {
                    var newTail = new ListNode<T>(element);
                    newTail.prevNode = this.tail;
                    this.tail.nextNode = newTail;
                    this.tail = newTail;
                }
                this.Count++;
            }
            public T RemoveFirst()
            {
                if (this.Count == 0) throw new InvalidOperationException("List empty");
                var firstElement = this.head.Value;
                this.head = this.head.nextNode;
                if (this.head != null) this.head.prevNode = null;
                else this.tail = null;
                this.Count--;
                return firstElement;
            }
            public T RemoveLast()
            {
                if (this.Count == 0) throw new InvalidOperationException("List empty");
                var lastElement = this.tail.Value;
                this.tail = this.tail.prevNode;
                if (this.tail != null) this.tail.nextNode = null;
                else this.head = null;
                this.Count--;
                return lastElement;
            }
            public T[] ToAarray()
            {
                var arr = new T[this.Count];
                int index = 0;
                ListNode<T> currentNode = this.head;
                while (currentNode != null)
                {
                    arr[index++] = currentNode.Value;
                    currentNode = currentNode.nextNode;
                }
                return arr;
            }
           public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> currentNode = this.head;
            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.nextNode;
            }
        }


        
    }

}
