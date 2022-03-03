using System;

class RecursiveFibonacci
{
	private static long[] fib;
	
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        fib = new long[n + 1];
        Console.WriteLine(Fib(n - 1));
    }
	public static long Fib(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        if (fib[n] != 0)
        {
            return fib[n];
        }

        fib[n] = Fib(n - 1) + Fib(n - 2);
        return fib[n];
    }
}