using System;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            // Reverse() is also good way
            Console.WriteLine(IsPalindrom("abca"));
            Console.WriteLine(IsPalindrom("abba"));
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