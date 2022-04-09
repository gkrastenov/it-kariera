using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "Stop shopping")
                    break;

                var array = userInput.Split('-').ToArray();

                string productName = array[0];
                decimal productPrice = decimal.Parse(array[1]);

                if (dictionary.ContainsKey(productName))
                    dictionary[productName] += productPrice;
                else 
                    dictionary.Add(productName, productPrice);
            }

            var sortedDictionary = dictionary.OrderBy(product => product.Value);

            decimal totalSum = 0;
            foreach (var product in sortedDictionary)
            {
                totalSum += product.Value;
                Console.WriteLine($"{product.Key}->{product.Value:F2}");
            }
            Console.WriteLine($"Total sum: {totalSum:F2}");
        }
    }
}