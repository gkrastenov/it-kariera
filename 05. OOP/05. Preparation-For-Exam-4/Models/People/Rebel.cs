using PreparationForExam4.Interfaces;

namespace PreparationForExam4.Models.People
{
    public class Rebel : Person, IRebel
    {
        private int harm;

        public Rebel(string name, int age, int harm)
            : base(name, age)
        {
            Harm = harm;
        }

        public int Harm
        {
            get { return harm; }
            set { HarmValidation(value); }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Harm: {harm}";
        }

        private void HarmValidation(int harm)
        {
            if (harm <= 0)
                throw new ArgumentException("Harm should be greater than 0!");
            this.harm = harm;
        }

        protected override void AgeValidation(int age)
        {
            base.AgeValidation(age);
            if (age > 50)
                throw new ArgumentException("Age should be less or equal to 50!");
        }
    }
}
