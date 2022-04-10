using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var players = new SortedDictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End of match")
                    break;

                var array = input.Split(" - ").ToArray();
                string playerName = array[0];
                int playerPasses = int.Parse(array[1]);

                if (players.ContainsKey(playerName))
                    players[playerName] += playerPasses;
                else players.Add(playerName, playerPasses);
            }

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key} has passed {player.Value} passes.");
            }
        }
    }
}