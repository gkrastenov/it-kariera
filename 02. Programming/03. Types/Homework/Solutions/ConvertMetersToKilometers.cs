using System;

class ConvertMetersToKilometers
{
    public static void Main()
    {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000M;
            Console.WriteLine($"{kilometers:f2}");
    }
}