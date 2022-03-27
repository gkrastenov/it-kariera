using System;
using System.Collections.Generic;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            List<string> messages = new List<string>();
            while (true)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "ReadMe")
                    break;
                messages.Add(currentInput);
            }

            for (int i = 0; i < messages.Count; i++)
            {
                if(IsValid(messages[i]))
                {
                    if(IsPalindrom(messages[i]))
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

            // jss.csh. -> invalid
            if (text[text.Length - 1] == '.')
                return false;

            // A phrase CANNOT contain whitespace characters
            // or the ‘_’ (underscore) character.

            if (text.Contains(' ') || text.Contains('_'))
                return false;

            // ... . ... -> valid
            // a.s . d.a -> valid -> 3 index
            // 132.31$.ddd -> valid -> 3 index, 7 index
            // 132.31$.ddd.aaa -> valid ->  3 index, 7 index, 11 index
            int index = 3;
            while (index < text.Length)
            {

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