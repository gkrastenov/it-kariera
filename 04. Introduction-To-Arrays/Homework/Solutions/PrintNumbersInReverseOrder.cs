using System;

class PrintNumbersInReverseOrder
{
    public static void Main()
    {
        int capacity = int.Parse(Console.ReadLine());
        int[] numbers = new int[capacity];

        for (int i = 0; i < capacity; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        Array.Reverse(numbers);
        Console.WriteLine(String.Join(" ", numbers));
    }
}