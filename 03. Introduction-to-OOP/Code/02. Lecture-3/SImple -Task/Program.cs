using System;

namespace Demo
{
    // Ако класа е static ВСИЧКО (fields,properties) трябва да ви бъде статично
    // статичните класове нямат constructor
    static class Program
    {
        public static void Main()
        {
            Person person1 = new Person(20, "Person1");
            Person person2 = new Person(30, "Person2");
            Person person3 = new Person(40, "Person3");
            Person person4 = new Person(50, "Person4");
            Person person5 = new Person(10, "Person5");

            Team team = new Team("Botev");
            team.AddPlayer(person1);
            team.AddPlayer(person2);
            team.AddPlayer(person3);
            team.AddPlayer(person4);
            team.AddPlayer(person5);

            Console.WriteLine("Count of all players in firstTeam :" + team.FirstTeam.Count);
            Console.WriteLine("Count of all players in reserveTeam :" + team.ReserveTeam.Count);
        }

        public static string Something()
        {
            return "";
        }
    }
}