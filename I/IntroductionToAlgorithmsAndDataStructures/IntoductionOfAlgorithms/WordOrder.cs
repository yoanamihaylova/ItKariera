using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOrder
{
    class WordOrder
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < words.Count-1; i++)
            {
                int ind = i;
                string minWord = words[i];
                for (int j = i+1; j < words.Count; j++)
                {
                    if(words[j].CompareTo(minWord)<0)
                    {
                        minWord = words[j];
                        ind=j;
                    }
                }
                string temp = words[i];
                words[i] = words[ind];
                words[ind] = temp;
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
