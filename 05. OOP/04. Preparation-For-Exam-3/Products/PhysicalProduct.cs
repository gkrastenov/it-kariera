namespace PreparationForExam3.Products
{
    public class PhysicalProduct : Product
    {
        private double weight;

        public PhysicalProduct(string name, double price, double weight)
            : base(name, price)
        {
            Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set { WeightValidation(value); }
        }

        private void WeightValidation(double weight)
        {
            if (weight < 0)
                throw new ArgumentException("Weight cannot be less or equal to 0!");
            this.weight = weight;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Weight: {weight:F2}";
        }
    }
}