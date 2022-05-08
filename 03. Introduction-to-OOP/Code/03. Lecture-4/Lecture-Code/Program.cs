using System;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            int param1 = 10;
            int param2 = 20;

            // Calculator calculator = new Calculator();
            // Console.WriteLine(calculator.Sum(param1, param2));

            Console.WriteLine(Calculator.Sum(param1, param2));
            Console.WriteLine(Calculator.Multiply(param1, param2));
            Console.WriteLine(Calculator.MySpecialNumber * param1);
        }
    }
}