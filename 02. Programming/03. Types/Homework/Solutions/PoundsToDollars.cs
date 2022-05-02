using System;

class PoundsToDollars
{
    public static void Main()
    {
        decimal pounds = decimal.Parse(Console.ReadLine());
        decimal dollars = pounds * 1.31M;
        Console.WriteLine($"{dollars:F3}");
    }
}