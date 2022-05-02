using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Team
    {
        // fields
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam; }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam; }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age > 40)
                reserveTeam.Add(person);
           else firstTeam.Add(person);
        }
    }
}
