using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END OF PATIENTS")              
                    break;
                
                if (input == "Add patient")
                {
                    names.Add(Console.ReadLine());
                }
                else if (input == "Add patient on position")
                {
                    var name = Console.ReadLine();
                    int position = int.Parse(Console.ReadLine());
                    names.Insert(position, name);
                }
                else if (input == "Remove patient on position")
                {
                    names.RemoveAt(int.Parse(Console.ReadLine()));
                }
                else if (input == "Remove last patient")
                {
                    names.RemoveAt(names.Count - 1);
                }
                else if (input == "Remove first patient")
                {
                    names.RemoveAt(0);
                }
            }
            Console.WriteLine(String.Join(" ", names));
        }
    }
}