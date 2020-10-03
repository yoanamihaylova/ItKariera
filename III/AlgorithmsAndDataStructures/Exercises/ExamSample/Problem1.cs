using System;

namespace Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            if (workingDays * 20 % 100 == 0) Console.WriteLine(workingDays*20/100);
            else
            {
                int vauchers = 0;
                vauchers += workingDays*20 / 100;
                if (vauchers == 0) vauchers += workingDays * 20 / 20;
                else
                {
                    workingDays -= 100 * vauchers / 20;
                    vauchers += workingDays * 20 / 20;
                }
                Console.WriteLine(vauchers);
            }
        }
    }
}
