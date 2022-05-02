using System;

class TownInfo
{
    public static void Main()
    {
        string town = Console.ReadLine();
        uint population = uint.Parse(Console.ReadLine());
        ushort area = ushort.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
    }
}