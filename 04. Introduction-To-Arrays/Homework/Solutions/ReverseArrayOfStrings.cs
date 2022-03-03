using System;

class ReverseArrayOfStrings
{
    public static void Main()
    {
            string[] strings = Console.ReadLine().Split();
            Array.Reverse(strings);

            Console.WriteLine(String.Join(" ", strings));
    }
}