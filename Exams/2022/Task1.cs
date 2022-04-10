using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var products = new Dictionary<string, decimal>();
            products.Add("computer", 0);
            products.Add("chair", 0);
            products.Add("desk", 0);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string productName = Console.ReadLine();
                products[productName] += 1; // increase value of the product
            }

            decimal totalSum = products["computer"] * 5899 + products["chair"] * 1699 +
                products["desk"] * 1789;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}