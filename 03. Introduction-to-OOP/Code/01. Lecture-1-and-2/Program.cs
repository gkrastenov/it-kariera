using System;
using System.Collections.Generic;

namespace Demo
{
    static class Program
    {
        public static void Main()
        {
            Person test = new Person();

            // ще запазя pointer към test в stack
            // ще запазя стойностите на age/name/flag в heap


            test.Age = -20;
            test.Age = 1;
            Console.WriteLine(test.Age);

            test.Age = 1;
            Console.WriteLine(test.Age);

            Person person = new Person();
            Console.WriteLine(person.Age); // използва get
           
            Person person2 = new Person(30, "Sasho Georgiev");
            Console.WriteLine(person2.Age); // използва get
            Console.WriteLine(person2.Name); // използва get

            Person person3 = new Person(30);
            Console.WriteLine(person3.Age); // използва get


            // encapsulation
            // person.age = 5; // -> !!!!! не трябва да се прави

            person.Age = 5;  // използва set
            person.Name = "Petur Petrov"; // използва set
            Console.WriteLine(person.ToString());

            person.Age = 6;  // използва set
            Console.WriteLine(person.Age); // използва get
            Console.WriteLine(person.Name); // използва get
            Console.WriteLine(person.ToString());     
        }

    }
}