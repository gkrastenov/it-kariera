using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // modifier -> private/public/protected/internal
    static class Calculator
    {
        // няма нужда от constructor
        // field/property/method ЗАДЪЛЖИТЕЛНО трябва да e статик

        // private  int field; // не работи
        // private static int field; // работи

        public static double MySpecialNumber = 84317.321;

        public static int Sum(int param1, int param2)
        {
            return param1 + param2;
        }

        public static int Multiply(int param1, int param2)
        {
            return param1 * param2;
        }
    }
}
