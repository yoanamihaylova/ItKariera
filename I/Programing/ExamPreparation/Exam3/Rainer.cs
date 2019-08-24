using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Rainer
    {
        static void Main(string[] args)
        {
            var original = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = original[original.Count() - 1];
            int[] output = new int[original.Count() - 1];
            int steps = 0;
            bool flag = false;
            for(int i=0;i< original.Count() - 1; i++)
            {
                output[i] = original[i];
            }
            for (int i = 0; i < original.Count() - 1; i++)
            {
                output[i]--;
            }
            if (output[index] == 0)
            {
                for (int i = 0; i < output.Count(); i++)
                {
                    if (output[i] == 0 && i != index) output[i] = original[i];
                    Console.Write(output[i]+" ");
                }
                Console.WriteLine();
                Console.WriteLine(steps);
            }
            else
            {
                while (flag!=true)
                {
                    index = int.Parse(Console.ReadLine());
                    
                    for (int i = 0; i < output.Count(); i++)
                    {
                        output[i]--;
                        if (output[i] == 0 && i != index ) output[i] = original[i];
                        //if(index == 0) 
                        if(output[index] == 0 && i==index)
                        {
                            for (int j = i+1; j < output.Count(); j++) output[j]--;
                            flag = true;
                            break;
                        }

                    }steps++;

                }
                for (int i = 0; i < output.Count(); i++)
                {
                   // if (i == 0 && i != index - 1) output[i] = original[i];
                    Console.Write(output[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(steps);
            }
        }

    }
}
