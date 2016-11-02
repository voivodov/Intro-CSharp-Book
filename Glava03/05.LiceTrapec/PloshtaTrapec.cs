using System;

namespace _05.LiceTrapec
{
    class PloshtaTrapec
    {
        static void Main(string[] args)
        {
            // Напишете израз, който изчислява площта на трапец по дадени a, b и h.

            Console.WriteLine("Площ на Трапец ");
            Console.WriteLine("Въведете едната основа: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете другата основа: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете височината: ");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Площа на трапеца е:" + Math.Round(area, 2));

        }
    }
}
