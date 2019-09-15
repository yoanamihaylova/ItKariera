using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class Stack
    {
        private List<String> list = new List<string>();
        public void Push(string element)
        {
            list.Add(element);
        }
        public string Pop()
        {
            string last = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return last;
        }
        public string Peek()
        {
            string last = list[list.Count - 1];
            return last;
        }
        public bool IsEmpty()
        {
            if (list.Count > 0) return false;
            else return true;
        }
        public override string ToString()
        {
            var result = "";
            foreach (var item in list)
            {
                result += item + " ";
            }
            return result.TrimEnd();
        }
    }
}
