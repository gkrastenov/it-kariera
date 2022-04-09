using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            Dictionary<string, int> colorDictionary = new Dictionary<string, int>();
            colorDictionary.Add("red", 0);
            colorDictionary.Add("orange", 0);
            colorDictionary.Add("blue", 0);
            colorDictionary.Add("green", 0);

            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                string color = Console.ReadLine();
                colorDictionary[color] += 1;
            }

            Console.WriteLine("Red egss: " + colorDictionary["red"]);
            Console.WriteLine("Orange egss: " + colorDictionary["orange"]);
            Console.WriteLine("Blue egss: " + colorDictionary["blue"]);
            Console.WriteLine("Green egss: " + colorDictionary["green"]);

            var sortedDictionary = colorDictionary.OrderByDescending(x=>x.Value);
            var firstElement = sortedDictionary.First();

            Console.WriteLine("Max egss: " + firstElement.Value + "->" + firstElement.Key);
        }
    }
}