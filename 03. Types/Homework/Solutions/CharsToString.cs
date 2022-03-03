using System;

class CharsToString
{
    public static void Main()
    {
        string sequence = string.Empty;
        for (int i = 0; i < 3; i++)
        {
            char symbol = char.Parse(Console.ReadLine());
            sequence += symbol;
		}

        Console.WriteLine(sequence);
    }
}