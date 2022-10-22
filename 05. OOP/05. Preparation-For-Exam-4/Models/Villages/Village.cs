using PreparationForExam4.Interfaces;
using PreparationForExam4.Models.People;
using System.Text;

namespace PreparationForExam4.Models.Villages
{
    public class Village : IVillage
    {
        private string name;
        private string location;
        private int resource;
        private List<Peasant> peasants;

        public Village(string name, string location)
        {
            Name = name;
            Location = location;
            peasants = new List<Peasant>();
        }

        public int Resource
        {
            get { return resource; }
            set { resource = value; }
        }

        public string Location
        {
            get { return location; }
            set { LocationValidation(value); }
        }

        public string Name
        {
            get { return name; }
            set { NameValidation(value); }
        }

        public void AddPeasant(Peasant peasant)
        {
            peasants.Add(peasant);
        }

        public List<Peasant> KillPeasants(int count)
        {
            if (count > peasants.Count)
                return peasants;

            var toBeRemoved = peasants.Take(count).ToList();
            peasants.RemoveRange(0, count);
            return toBeRemoved; // TODO: view
        }

        public int PassDay()
        {
            var sumOfProductivities = peasants.Sum(p => p.Productivity);
            resource = sumOfProductivities;
            return resource;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Village - {name} ({location})");
            sb.AppendLine($"Resources - {resource}");
            sb.AppendLine($"Peasants – ({peasants.Count})");
            foreach (var currentPeasant in peasants)
            {
                sb.AppendLine(currentPeasant.ToString());
            }
            return sb.ToString();
        }

        private void LocationValidation(string location)
        {
            if (location is null || name.Length < 3 || location.Length > 45)
                throw new ArgumentException("Location should be between 3 and 45 characters!");
            this.location = location;
        }

        private void NameValidation(string name)
        {
            if (name is null || name.Length < 2 || name.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            this.name = name;
        }
    }
}