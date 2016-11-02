using System;

namespace _06.PerimeturILiceNaTriugulnik
{
    class PerimeturILiceNaTriugulnik
    {
        static void Main(string[] args)
        {
            // Напишете програма, която за подадени от потребителя дължина и височина на правоъгълник пресмята и отпечатва на конзолата неговия периметър и лице.

            Console.WriteLine("Периметър и лице на правоъгълник ");
            Console.WriteLine("Въведете едната страна: ");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Въседете другата страна: ");
            long b = long.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на правоъгълника е: " + (a * b) + "\nПериметъра на правоъгълника е: " + ((2 * a) + (2 * b)));
        }
    }
}
