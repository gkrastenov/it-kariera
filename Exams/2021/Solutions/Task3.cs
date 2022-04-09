using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            List<string> noSpecialList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();

                bool isEqual = IsEqualFirstAndLastSymbol(word);
                if (isEqual)
                    firstList.Add(word);

                bool haveMore = HaveMoreThanTwoSymbolsA(word);
                if (haveMore)
                    secondList.Add(word);

                if (!isEqual && !haveMore)
                    noSpecialList.Add(word);
            }

            Console.WriteLine(string.Join(", ", firstList));
            Console.WriteLine(string.Join(", ", secondList));
            Console.WriteLine(string.Join(", ", noSpecialList));
        }

        private static bool IsEqualFirstAndLastSymbol(string word)
        {
            return word[0] == word[word.Length - 1];
        }

        private static bool HaveMoreThanTwoSymbolsA(string word)
        {
            // first approach: with one for loop
            // second approach:
            return word.Count(symbol => symbol == 'a') >= 2;
        }
    }
}