using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threat2
{
    class Threat2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] a = line.Split(' ').ToArray();
            string comands = Console.ReadLine();
            
            int StartIndex, EndIndex, Parts;
            while (comands != "3:1")
            {
                string[] c = comands.Split(' ').ToArray();
                if (c[0] == "merge")
                {
                    StartIndex = int.Parse(c[1]);
                    if (StartIndex < 0) StartIndex = 0;
                    EndIndex = int.Parse(c[2]);
                    if (EndIndex > a.Count() - 1) EndIndex = a.Count() - 1;
                    int i = 0;
                    int br = 0;
                    while (br < EndIndex)
                    {
                        if (line[i] == ' ')
                        {
                            br++;
                            if (br > StartIndex) line = line.Remove(i, 1);
                        }
                        i++;
                    }
                }
                else
                {
                    StartIndex = int.Parse(c[1]);
                    if (StartIndex < 0) StartIndex = 0;
                    if (StartIndex > a.Count() - 1) StartIndex = a.Count() - 1;
                    Parts = int.Parse(c[2]);
                    // if ( > a.Count() - 1) EndIndex = a.Count() - 1;
                }
                comands = Console.ReadLine();
         
            }
            Console.WriteLine(line);
        }
    }
}
