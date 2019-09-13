using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferedConsole
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BufferedConsole bufferedConsole = new BufferedConsole();

            /*using (bufferedConsole)
            {
                bufferedConsole.Write(new string('W', 49));
                bufferedConsole.Write(new string('O', 2));
                bufferedConsole.Write(new string('b', 20));
                bufferedConsole.Write(new string('r', 20));
                bufferedConsole.Write(new string('*', 20));

                bufferedConsole.Dispose();
            }*/
            
            try
            {
                bufferedConsole.Write(new string('m', 49));
                bufferedConsole.Write(new string('s', 2));
            }
            finally
            {
                ((IDisposable)bufferedConsole).Dispose();
            }
        }
    }
}
