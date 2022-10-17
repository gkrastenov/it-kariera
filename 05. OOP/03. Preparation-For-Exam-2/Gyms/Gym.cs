using OOPExam3.Athletes.Interfaces;
using OOPExam3.Equipments.Interfaces;
using System.Text;

namespace OOPExam3.Gyms
{
    public abstract class Gym
    {
        private string name;
        private int capacity;

        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Equipment = new List<IEquipment>();
            Athletes = new List<IAthlete>();
        }

        public ICollection<IEquipment> Equipment { get; }
        public ICollection<IAthlete> Athletes { get; }

        public double EquipmentWeight
        {
            get { return Equipment.Sum(eq => eq.Weight); }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Name
        {
            get { return name; }
            set { NameValidation(value); }
        }

        public void AddAthlete(IAthlete athlete)
        {
            if (capacity <= Athletes.Count)
                throw new InvalidOperationException("Not enough space in the gym.");
            Athletes.Add(athlete);
        }
        public bool Removethlete(IAthlete athlete)
        {
            // fullName is unique
            bool isFounded = Athletes.Any(ath => ath.FullName == athlete.FullName);
            if (isFounded)
                Athletes.Remove(athlete);
            return isFounded;
        }

        public void AddEquipment(IEquipment equipment)
        {
            Equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var currentAthlete in Athletes)
            {
                currentAthlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} is a {typeof(Gym).Name}:");
            sb.AppendLine("Athletes: ");
            foreach (var currentAthlete in Athletes)
            {
                sb.Append($"{currentAthlete.FullName},");
            }
            sb.AppendLine($"Equipment total count: {Equipment.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight}");
            return sb.ToString();
        }

        private void NameValidation(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Gym name can not be null or empty");
            this.name = name;
        }
    }
}