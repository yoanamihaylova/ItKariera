using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string comands = Console.ReadLine();
            int StartIndex, EndIndex, Parts;
            while (comands != "3:1")
            {
                  int br = 0;
                  if (comands.IndexOf("merge")!=-1)
                  {                 
                    StartIndex = (int)comands[6]-'0';
                    EndIndex = (int)comands[8]-'0';
                    int i = 0;
                    while(br<EndIndex)//br<=endIndex
                    {
                        
                        if (line[i]==' ')
                        {
                            br++;
                            if(br>StartIndex) line = line.Remove(i, 1);
                            if(i>line.Length) continue;
                        }
                        i++;
                    }

                  }
                  else
                  {
                    int length = 0;
                    StartIndex = (int)comands[7] - '0';
                    Parts = (int)comands[9] - '0';
                    int i = 0;
                    while(length!=StartIndex)
                    {
                        length++;
                        i++;
                    }
                    while(line[i]!=' ')
                    {
                        br++;
                        i++;
                    }
                    if(br%Parts==0)
                    {
                        for (int j = br/Parts; j <= br; j+=br/Parts+1)
                        {
                            line = line.Insert(j, " ");
                        }
                    }
                  }
                comands = Console.ReadLine();
            }
            Console.WriteLine(line);
        }
    }
}
