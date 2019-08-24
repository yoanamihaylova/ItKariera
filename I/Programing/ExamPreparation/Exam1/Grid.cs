using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Grid
    {
        static void Main(string[] args)
        {
            string word;
            string word_reverse = "";
            bool flag = true;
            while (( word = Console.ReadLine() )!= "ReadMe")
            {
                flag = true;
                if (word.Contains(" ") || word.Contains("_") || word.Contains("\t")) flag = false;
                else if (word.Length % 4 != 3) flag = false;
                if (word.Contains('.'))
                {
                    bool flag1 = false;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != '.') flag1 = true;
                    }
                    if (word.Length < 4 && flag1==true) flag = false;
                }
                else
                {
                    for (int i = 3; i < word.Length; i += 4)
                    {
                        if (word[i] != '.')
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag == true)
                {
                    word_reverse = "";
                    for (int i = word.Length-1;i>=0;i--)
                    {
                        word_reverse += word[i];
                    }
                    if (word_reverse == word) flag = true;
                    else flag = false;
                }
                if (flag == false) Console.WriteLine("NO");
                else if(flag == true) Console.WriteLine("YES");
            }
        }
    }
}
