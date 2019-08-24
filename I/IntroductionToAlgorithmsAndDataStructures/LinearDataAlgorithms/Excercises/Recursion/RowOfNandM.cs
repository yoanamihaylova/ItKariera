using System;
using System.Collections.Generic;
using System.Linq;

namespace RowOfNandM
{
    class RowOfNandM
    {
        static void Main(string[] args)
        {
            Queue<Element> q = new Queue<Element>();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = numbers[0];
            int m = numbers[1];
            q.Enqueue(new Element(n,null));
            while(q.Count!=0)
            {
                Element t = q.Dequeue();
                if(t.Value<m)
                {
                    q.Enqueue(new Element(t.Value + 1, t));
                    q.Enqueue(new Element(t.Value + 2, t));
                    q.Enqueue(new Element(t.Value * 2, t));
                }
                if(t.Value == m)
                {
                    PrintSequence(t.Previous);
                    Console.WriteLine(t.Value);
                    return;
                }
            }
            Console.WriteLine("No solution");
            return;
        }

        static void PrintSequence(Element t)
        {
            if(t!=null)
            {
                PrintSequence(t.Previous);
                Console.Write(t.Value + " -> ");
            }

        }
    }

    public class Element
    {
        public int Value { get; set; }
        public Element Previous { get; set; }
        public Element(int value, Element previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}
