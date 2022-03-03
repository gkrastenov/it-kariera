using System;

class RefactorVolumeOfPyramid 
{
    public static void Main()
    {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double volume = (length * width * height) / 3;
        Console.Write($"Pyramid Volume: {volume:F2}");
    }
}