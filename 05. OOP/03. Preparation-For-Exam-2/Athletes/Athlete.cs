using OOPExam3.Athletes.Interfaces;

namespace OOPExam3.Athletes
{
    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int stamina;
        private int numberOfMedals;

        public Athlete(string fullName, string motivation, int stamina, int numberOfMedals)
        {
            FullName = fullName;
            Motivation = motivation;
            Stamina = stamina;
            NumberOfMedals = numberOfMedals;
        }

        public int NumberOfMedals
        {
            get { return numberOfMedals; }
            set { NumberOfMedalsValidation(value); }
        }

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public string Motivation
        {
            get { return motivation; }
            set { MotivationValidation(value); }
        }

        public string FullName
        {
            get { return fullName; }
            set { FullNameValidation(value); }
        }

        public abstract void Exercise();

        private void FullNameValidation(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                throw new ArgumentException("Athlete name can not be null or empty.");
            this.fullName = fullName;
        }

        private void MotivationValidation(string motivation)
        {
            if (string.IsNullOrEmpty(motivation))
                throw new ArgumentException("The motivation can not be null or empty");
            this.motivation = motivation;
        }

        private void NumberOfMedalsValidation(int numberOfMedals)
        {
            if (numberOfMedals < 0)
                throw new ArgumentException("Athlete number of mdeals can not be below 0.");
            this.numberOfMedals = numberOfMedals;
        }

    }
}