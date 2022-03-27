using System;
using System.Collections.Generic;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            List<string> input = new List<string>();
            while (true)
            {
                string currentInput = Console.ReadLine();

                if (currentInput == "ReadMe")
                    break;
                input.Add(currentInput);
            }

            foreach (var element in input)
            {
                if (IsValid(element))
                {
                    if (IsPalindrom(element))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        
        public static bool IsValid(string text)
        {
            if (text.Length < 3)
                return false;

            if (text.Length == 3)
                return true;

            if (text.Contains('_'))
                return false;

            if (text.Contains(' '))
                return false;

            int index = 3;
            while (index < text.Length)
            {
                if (index + 3 == text.Length - 1)
                    break;

                if (text[index] != '.')
                    return false;

                index += 4;
            }

            return true;
        }
        public static bool IsPalindrom(string text)
        {
            if (text.Length == 1)
                return true;

            int startIndex = 0;
            int lastIndex = text.Length - 1;

            while (startIndex < lastIndex)
            {
                if (text[startIndex] == ' ' || text[lastIndex] == ' ')
                    return false;

                if (text[startIndex] != text[lastIndex])
                    return false;

                ++startIndex;
                --lastIndex;
            }
            return true;
        }
    }
}