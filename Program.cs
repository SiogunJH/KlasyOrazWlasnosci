using System;

namespace KlasyProperties
{
    class Zadanie
    {
        public static void Main()
        {
            Triangle sample;

            sample = new Triangle(12, 13, 14);
            Console.WriteLine(sample); //.ToString
            Console.WriteLine(sample.Circuit);
            Console.WriteLine(sample.Area);

            Console.WriteLine();

            sample = new Triangle();
            Console.WriteLine(sample); //.ToString
            Console.WriteLine(sample.Circuit);
            Console.WriteLine(sample.Area);
        }
    }
}