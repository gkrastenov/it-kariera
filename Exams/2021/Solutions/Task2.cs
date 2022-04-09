using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            List<int> oddNumbersList = new List<int>();
            List<int> evenNumbersList = new List<int>();
            List<int> sumOfFiveList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                if (number % 2 == 0)
                     evenNumbersList.Add(number);
                else oddNumbersList.Add(number);

                if (SumOfDigitsIsFive(number))
                    sumOfFiveList.Add(number);
            }

            Console.WriteLine(string.Join(", ", evenNumbersList));
            Console.WriteLine(string.Join(", ", oddNumbersList));
            Console.WriteLine(string.Join(", ", sumOfFiveList));
        }

        private static bool SumOfDigitsIsFive(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum % 5 == 0;
        }
    }
}