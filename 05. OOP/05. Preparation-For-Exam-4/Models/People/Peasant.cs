namespace PreparationForExam4.Models.People
{
    public class Peasant : Person
    {
        private int productivity;

        public Peasant(string name, int age, int productivity)
            : base(name, age)
        {
            Productivity = productivity;
        }

        public int Productivity
        {
            get { return productivity; }
            set { ProductivityValidation(value); }
        }

        private void ProductivityValidation(int productivity)
        {
            if (productivity <= 0)
                throw new ArgumentException("Productivity cannot be less or equal to 0!");
            this.productivity = productivity;
        }

        protected override void AgeValidation(int age)
        {
            base.AgeValidation(age);
            if (age > 110)
                throw new ArgumentException("Age cannot be greater than 110!");
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Productivity: {productivity}";
        }
    }
}