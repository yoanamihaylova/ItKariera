using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public class myIObserver
    {
        public void Notify()
        {
           Console.WriteLine("Recived notification!");
        }
    }
}