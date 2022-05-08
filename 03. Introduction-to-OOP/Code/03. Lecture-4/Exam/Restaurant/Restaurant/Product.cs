using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        /*
         * Name – низ, съставен от малки и големи латински букви, както и цифри, но без други специални знаци
         Price – число с плаваща запетая
        Weight – цяло число в интервала [1, 10000]

         * 
         * 
         */
        private string name;
        private double price;
        private int weight;

        public Product(string name, double price, int weight)
        {
            // ползвам properties
            Name = name;
            Price = price;
            Weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { ValidateWeight(value); }
        }

        public double Price
        {
            get { return price; }
            set { ValidatePrice(value); }
        }

        public string Name
        {
            get { return name; }
            set { ValidateName(value); }
        }

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.OrderBy(product => product.Value.Price).First().Value;
        }

        private void ValidatePrice(double price)
        {
            if (price < 0.01)
                throw new ArgumentException("Invalid price!");
            this.price = price;
        }

        private void ValidateName(string name)
        {
            if (name.Length < 3)
                throw new ArgumentException("Invalid name!");
            this.name = name;
        }

        private void ValidateWeight(int weight)
        {
            if (weight <0 )
                throw new ArgumentException("Invalid weight!");
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{name} - {weight}";
        }
    }
}
