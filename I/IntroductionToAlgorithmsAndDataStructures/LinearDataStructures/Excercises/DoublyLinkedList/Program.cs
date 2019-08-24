using System;
using System.Linq;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddLast(5);
            dll.AddLast(3);
            dll.ForEach(Console.WriteLine);
            dll.RemoveFirst();
            //dll.RemoveLast();
            Console.WriteLine(String.Join(" ",dll.ToAarray()));
            
        }
    }
}
