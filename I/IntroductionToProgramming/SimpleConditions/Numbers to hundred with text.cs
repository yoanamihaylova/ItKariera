using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_hundred_with_text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            string str = "";
            if (num == 0) Console.WriteLine("zero");
            while (num != 0)
            {
                if (num == 1) { str = str + "one"; num = 0; }
                else if (num == 2) { str = str + "two"; num = 0; }
                else if (num == 3) { str = str + "three"; num = 0; }
                else if (num == 4) { str = str + "four"; num = 0; }
                else if (num == 5) { str = str + "five"; num = 0; }
                else if (num == 6) { str = str + "six"; num = 0; }
                else if (num == 7) { str = str + "seven"; num = 0; }
                else if (num == 8) { str = str + "eight"; num = 0; }
                else if (num == 9) { str = str + "nine"; num = 0; }
                else if (num == 10) { str = str + "ten"; num = 0; }
                else if (num == 11) { str = str + "eleven"; num = 0; }
                else if (num == 12) { str = str + "twelve"; num = 0; }
                else if (num == 13) { str = str + "thirteen"; num = 0; }
                else if (num == 14) { str = str + "fourteen"; num = 0; }
                else if (num == 15) { str = str + "fifteen"; num = 0; }
                else if (num == 16) { str = str + "sixteen"; num = 0; }
                else if (num == 17) { str = str + "seventeen"; num = 0; }
                else if (num == 18) { str = str + "eighteen"; num = 0; }
                else if (num == 19) { str = str + "nineteen"; num = 0; }

                else if (num >= 20 && num < 30) { str = str + "Twenty "; num = num - 20; }
                else if (num >= 30 && num < 40) { str = str + "Thirty "; num = num - 30; }
                else if (num >= 40 && num < 50) { str = str + "Forty "; num = num - 40; }
                else if (num >= 50 && num < 60) { str = str + "Fifty "; num = num - 50; }
                else if (num >= 60 && num < 70) { str = str + "Sixty "; num = num - 60; }
                else if (num >= 70 && num < 80) { str = str + "Seventy "; num = num - 70; }
                else if (num >= 80 && num < 90) { str = str + "Eighty "; num = num - 80; }
                else if (num >= 90 && num < 100) { str = str + "Ninety "; num = num - 90; }

                else if (num == 100) str = str + "One hundred"; num = num - 100;
            }
            Console.WriteLine(str);
            }
        }
}
