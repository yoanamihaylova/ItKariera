using System;


namespace EVentArgsDemo
{
    public delegate void myDelegate(object sender, MyEventArgs args);
    public class Person
    {
        private string name;
        public event myDelegate handler;

        public string Name
        {
            
            get { return name; }
            set { 
                MyEventArgs args = new MyEventArgs();
                args.OldName = this.name;
                name = value;
                Notify(args);
            }
        }

        private void Notify(MyEventArgs args)
        {
            handler(this, args);
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
    public class EventsArgsDemo
    { 
        static void Main(string[] args)
        {
            Person person = new Person("Pesho");
            person.handler += (sender, argss) =>
            {
                Person senderObj = (Person)sender;
                Console.WriteLine($"Change sender name from {argss.OldName} to {senderObj.Name}.");
            };
            person.Name = "Ivan";
        }
    }
}
