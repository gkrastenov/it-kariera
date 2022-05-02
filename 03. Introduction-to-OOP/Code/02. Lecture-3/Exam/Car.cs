using System;

namespace Exam
{
    public class Car
    {
        private int number;
        private double price;
        
        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }

        public double Price
        {
            get { return price; }
            private set { IsValidPrice(value);  }
        }

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }

        private void IsValidPrice(double price)
        {
            if(price < 1000)
            {
                this.price = 0;
                throw new ArgumentException("Invalid car price!");
            }
            this.price = price;
        }

        public override string ToString()
        {
            return $"Car number {this.number} costs {this.price:F2}";
        }
    }
}
