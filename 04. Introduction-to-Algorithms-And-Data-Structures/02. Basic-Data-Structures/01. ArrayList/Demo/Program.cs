using System;
using CustomArrayList;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);

            bool haveToBeTrue = arrayList.Contains(40);
            Console.WriteLine(haveToBeTrue);

            bool haveToBeFalse = arrayList.Contains(50);
            Console.WriteLine(haveToBeFalse);

            arrayList.Add(50);
            arrayList.Add(60);
            arrayList.Add(70);
            arrayList.Add(80);
            arrayList.Add(90);
            arrayList.Add(1000000);

            int haveToBeTen = arrayList.GetByIndex(0);
            Console.WriteLine(haveToBeTen);

            arrayList.Remove(80);
            arrayList.SetByIndex(7, 800);

            Console.WriteLine(arrayList.ToString());
        }
    }
}