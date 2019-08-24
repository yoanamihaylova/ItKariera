using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterIndex
{
    class LetterIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine('a'-97);
            string word;
            word = Console.ReadLine();
            for(int i=0;i<word.Length;i++)
            {
                Console.WriteLine("{0} -> {1}",word[i],word[i]-97);
            }
        }
    }
}
