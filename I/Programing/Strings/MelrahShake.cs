using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string mask = Console.ReadLine();
            int n = s.Length;
            int brr = 0;
            while (mask != "" || s.Length>mask.Length)
            {

                while(s.Contains(mask))
                {
                    s = s.Remove(s.IndexOf(mask), mask.Length);
                    brr++;
                }
                    if (brr>=2)
                {
                    Console.WriteLine("Shaked it.");
                    brr = 0;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(s);
                    n = s.Length;
                    break;
                }
                mask = mask.Remove(mask.Length/2,1);
            }
        }
    }
}
