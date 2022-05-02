using System;
using System.Linq;

class EvenAndOddSubstraction
{
    public static void Main()
    {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int evenSum = 0;
            int oddSum = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine(evenSum - oddSum);
    }
}