using System;

namespace PreparationForExam3.Products
{
    public class ServiceProduct : Product
    {
        private double time;

        public ServiceProduct(string name, double price, double time)
            : base(name, price)
        {
            Time = time;
        }

        public double Time
        {
            get { return time; }
            set { TimeValidation(value); }
        }

        private void TimeValidation(double time)
        {
            if (time < 0)
                throw new ArgumentException("Time should be greater than 0!");
            this.time = time;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Time: {time:F2}";
        }
    }
}
