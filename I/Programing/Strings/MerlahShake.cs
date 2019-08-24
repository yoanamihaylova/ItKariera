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
            while (mask.Length>0 && s.Length >= mask.Length)
            {

                if (s.IndexOf(mask)!=s.LastIndexOf(mask) && s.IndexOf(mask) !=-1)
                {
                    s = s.Remove(s.IndexOf(mask), mask.Length);
                    s = s.Remove(s.LastIndexOf(mask), mask.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
                mask = mask.Remove(mask.Length / 2, 1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(s);
        }
    }
}

