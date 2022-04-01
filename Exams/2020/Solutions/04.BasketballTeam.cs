using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var sortedDictionary = new SortedDictionary<string, int>();
           
            // Input:
            while (true)
            {
                string input = Console.ReadLine(); // Simona - 20
                if (input == "END")
                    break;

                string[] arr = input.Split(" - ").ToArray();

                // arr[0] -> "Simona" -> type string -> Key
                // arr[1] -> "20" -> type string -> Value

                string name = arr[0];
                int points = Convert.ToInt32(arr[1]);

                // searching if name constians in dicitonary
                if(sortedDictionary.ContainsKey(name))
                {
                    sortedDictionary[name] += points;
                }
                else
                {
                    sortedDictionary.Add(arr[0], points);
                }
            }

            // Output
            foreach (var element in sortedDictionary)
            {
                Console.WriteLine(element.Key + " -> " + element.Value);
            }
        }
    }
}