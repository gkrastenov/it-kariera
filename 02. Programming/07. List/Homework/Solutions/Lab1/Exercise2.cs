using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
        }
    }
}