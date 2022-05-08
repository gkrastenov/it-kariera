using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Meal
    {
        // fields
        private string name;
        private string type;
        private List<Product> products;
        private int ordered;

        public Meal(string name, string type)
        {
            Name = name;
            Type = type;
            Products = new List<Product>(); // правя го това, за да не бъде products null
            Ordered = 0;
        }

        public Meal(string name, string type, List<Product> products)
        {
            Name = name;
            Type = type;
            Products = products;
            Ordered = 0;
        }

        // properties
        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public string Type
        {
            get { return type; }
            set { ValidateType(value); }
        }

        public string Name
        {
            get { return name; }
            set { ValidateName(value); }
        }

        public double Price
        {
            get { return CalculatePrice(); }

        }

        // methods
        /*Всяко ястие си има и цена, която се изчислява по следния алгоритъм:
         1.	Сумират се всички цени на продуктите, участващи в състава на ястието
         2.	Крайната цена е сумата  от цените на продуктите и 30% надценка.
            */
        private double CalculatePrice()
        {
            double totalSum = products.Sum(product => product.Price);
            return totalSum + (totalSum / 100 * 30);
        }
        /// <summary>
        /// Добавя даден продукт към списъка с ястия
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            products.Add(product);
        }


        public bool ContainsProduct(string name)
        {
            return products.Any(product => product.Name == name);
        }

        /*o	Трябва да изведете един ред с 25 символа “-”. 
           o На следващия ред трябва да изведете “<ястие> RECIPE”. 
           o След това да изведете още един ред с 25 символа “-”. 
           o За всеки продукт изведете по един ред във формата:
            <име> - <грамаж>
           o Накрая изведете още един ред с 25 символа “-”.
        */

        public void PrintRecipe()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine($"{name} RECIPE");
            Console.WriteLine(new String('-', 25));
            foreach (Product currentProduct in products)
            {
                Console.WriteLine(currentProduct.ToString());
            }
            Console.WriteLine(new String('-', 25));
        }

        public void Order()
        {
            ordered += 1;
        }


        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
           return meals.OrderByDescending(meal => meal.Value.Ordered).First().Value;
        }

        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            var recommendedMeals = meals.Where(meal => meal.Value.Price <= price)
                .OrderByDescending(meal => meal.Value.Price);
            return recommendedMeals.First().Value;
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            var recommendedMeals = meals.Where(meal => meal.Value.Price <= price && meal.Value.Type == type)
                 .OrderByDescending(meal => meal.Value.Price);
            return recommendedMeals.First().Value;
        }

        private void ValidateName(string name)
        {
            if (name.Length < 3)
                throw new ArgumentException("Invalid name!");
            this.name = name;
        }

        private void ValidateType(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Invalid type!");
            this.type = type;
        }

        public override string ToString()
        {
            return $"{name} - {type}";
        }
    }
}