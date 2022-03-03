using System;
using System.Linq;

class SumEvenNumbers
{
    public static void Main()
    {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int sum = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
					sum += num;
            }
            Console.WriteLine(sum);
    }
}