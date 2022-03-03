using System;

class LowerOrUpper
{
    public static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (symbol >= 65 && symbol <= 90)
        {
        Console.WriteLine("upper-case");
        }
        else if (symbol >= 97 && symbol <= 122)
        {
                Console.WriteLine("lower-case");
        }
    }
}