using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        List<Person> Name = new List<Person>();
        /*public List<Person> Names
        {
            get { return Name; }
            set { Name = value; }
        }*/
        public void AddMember(Person person)
        {
            Name.Add(person);
        }
        public Person GetOldestMemeber()
        {
            return Name.OrderByDescending(p => p.Age).First();
        }
    }
}
