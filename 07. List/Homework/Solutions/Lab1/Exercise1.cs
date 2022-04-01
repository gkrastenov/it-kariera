using System;
using System.Collections.Generic;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
        }
    }
}