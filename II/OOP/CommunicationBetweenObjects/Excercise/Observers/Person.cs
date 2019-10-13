using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;
                this.OnNameChange();
            }
        }
        public void OnNameChange()
        {
            foreach (var observer in observers)
            {
                observer.Notify();
            }
        }
        private List<myIObserver> observers;
        public Person()
        {
            this.observers = new List<myIObserver>();
        }
        public void AddObserver (myIObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(myIObserver observer)
        {
            observers.Remove(observer);
        }


    }
}
