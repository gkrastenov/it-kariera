using System;
using System.Linq;

class RoudingNumbers
{
    public static void Main()
    {
           double[] nums = Console.ReadLine()
                                   .Split()
                                   .Select(double.Parse)
                                   .ToArray();

            foreach (double num in nums)
            {
                Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
    }
}