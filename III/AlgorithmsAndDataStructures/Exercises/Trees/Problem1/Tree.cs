using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Tree<T>
    {
        public T Value { get; private set; }
        public Tree<T> Parent { get; set; }
        public List<Tree<T>> Children { get; private set; }

        public Tree(T value)
        {
            Value = value;
            Children = new List<Tree<T>>();
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', indent * 2));
            Console.WriteLine(Value);

            foreach (Tree<T> child in Children)
            {
                child.Print(indent + 1);
            }
        }
    }
}
