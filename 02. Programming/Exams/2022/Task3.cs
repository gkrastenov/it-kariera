using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var names = new Dictionary<string, int>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END OF GAME")
                    break;

                if (names.ContainsKey(name))
                    names[name] += GetPoints(name);
               else names.Add(name, GetPoints(name));
                  
            }

            var winner = names.OrderByDescending(name => name.Value).First();

            Console.WriteLine("Winner is name: " + winner.Key);
            Console.WriteLine("Points: " + winner.Value);
        }
        private static int GetPoints(string name)
        {
            int totalPoints = 0;

            if (name[name.Length - 1] == 'a')
                totalPoints += 10;

            if (name[name.Length - 1] == 'v')
                totalPoints += 13;

            if (name.Length >= 7)
                totalPoints += 33;
           else totalPoints += 22;

            return totalPoints;
        }
    }
}