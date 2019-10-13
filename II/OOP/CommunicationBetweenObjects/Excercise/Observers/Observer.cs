using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class Observer : myIObserver
    {
        public void Notify()
        {
            Console.WriteLine("Recived notification!");
        }
    }
}
