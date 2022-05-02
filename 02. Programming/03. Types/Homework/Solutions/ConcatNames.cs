using System;

class ConcatNames
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string delimeter = Console.ReadLine();

        Console.WriteLine($"{firstName}{delimeter}{lastName}");
    }
}