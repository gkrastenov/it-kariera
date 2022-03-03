using System;

class ExactSumOfRealNumbers
{
    public static void Main()
    {
         int numbers = int.Parse(Console.ReadLine());
         decimal sum = 0;

         for (int i = 0; i < numbers; i++)
         {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
		 }
         Console.WriteLine(sum);
    }
}