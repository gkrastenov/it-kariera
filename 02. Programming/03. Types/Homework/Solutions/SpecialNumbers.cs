using System;

class SpecialNumbers
{
    public static void Main()
    {
			int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string digits = i.ToString();
                int sum = 0;
                foreach (char digit in digits)
                {
                    sum += digit - '0';
                }

                switch (sum)
                {
					
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{i} -> True");
                        break;
                    default:
                        Console.WriteLine($"{i} -> False");
                        break;

                }
			}
    }
}