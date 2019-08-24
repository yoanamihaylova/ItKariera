using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Person> firstTeam;

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam; }
        }

        private List<Person> reserveTeam;

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam; }
        }
        public Team(string name)
        {
            this.Name = name;
        }
        public void AddPlayer(Person person)
        {
            if (person.Age >= 40) reserveTeam.Add(person);
            else firstTeam.Add(person);
        }

    }
}
