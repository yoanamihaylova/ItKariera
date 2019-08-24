using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCast
{
    class RainCast
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<string> list = new List<string>();
            while(input != "Davai Emo")
            {
                list.Add(input);
                input = Console.ReadLine();
            }
            bool flag = false;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Contains("Normal") || list[i].Contains("Danger") || list[i].Contains("Warning")) flag = true;

            }

        }
    }
}
