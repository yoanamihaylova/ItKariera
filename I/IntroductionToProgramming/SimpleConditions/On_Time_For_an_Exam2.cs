using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_For_an_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexam, mexam;
            hexam = int.Parse(Console.ReadLine());
            mexam = int.Parse(Console.ReadLine());
            int harrival, marrival;
            harrival = int.Parse(Console.ReadLine());
            marrival = int.Parse(Console.ReadLine());
            if (harrival * 60 + marrival == hexam * 60 + mexam) Console.WriteLine("On time");
            else if ((harrival * 60 + marrival < hexam * 60 + mexam) && ((hexam * 60 + mexam - (harrival * 60 + marrival)) <= 30))
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", ((hexam * 60 + mexam) - (harrival * 60 + marrival)));
            }
            else if (harrival * 60 + marrival > hexam * 60 + mexam)
            {
                Console.WriteLine("Late");
                if ((((harrival * 60 + marrival) - (hexam * 60 + mexam)) / 60) == 0) Console.WriteLine("{0} minutes after the start", ((harrival * 60 + marrival) - (hexam * 60 + mexam)));
                else Console.WriteLine("{0}:{1:d2} hours after the start", ((harrival * 60 + marrival) - (hexam * 60 + mexam)) / 60, ((harrival * 60 + marrival) - (hexam * 60 + mexam)) % 60);
            }
            else if (harrival * 60 + marrival < hexam * 60 + mexam)
            {

                {
                    Console.WriteLine("Early");
                    if ((((hexam * 60 + mexam) - (harrival * 60 + marrival)) / 60) == 0) Console.WriteLine("{0} minutes before the start", ((hexam * 60 + mexam) - (harrival * 60 + marrival)));
                    else Console.WriteLine("{0}:{1:d2} hours before the start", ((hexam * 60 + mexam) - (harrival * 60 + marrival)) / 60, ((hexam * 60 + mexam) - (harrival * 60 + marrival)) % 60);
                }
            }

        }
    }
}
