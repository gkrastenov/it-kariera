using System;

class PascalTriangle
{
    public static void Main()
    {
            int n = int.Parse(Console.ReadLine());
            int value = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        value = 1;
                    }
                    else
                    {
                        value = value * (i - j + 1) / j;
                    }

                    Console.Write(value + " ");
                }

                Console.WriteLine();
            }
    }
}