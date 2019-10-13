using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            myIObserver observer = new Observer();
            myIObserver observer1 = new Observer();
            person.AddObserver(observer);
            person.AddObserver(observer1);
            person.Name = "NewName";
        }
    }
}
