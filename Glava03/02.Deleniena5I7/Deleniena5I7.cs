using System;

namespace _02.Deleniena5I7
{
    class Deleniena5I7
    {
        static void Main(string[] args)
        {
            // Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

            Console.WriteLine("Въведи Число и Разбери Дали Се Дели На 5 И 7: ");
            long num = long.Parse(Console.ReadLine());
            if (((num % 5) == 0) & ((num % 7) == 0))
            {
                Console.WriteLine("Числото се дели на 5 и 7");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Числото се дели само на 5");
            }
            else if (num % 7 == 0)
                {
                Console.WriteLine("Числото се дели само на 7");
                 }
            else
            {
                Console.WriteLine("Числото не се дели на 5 и 7");
            }
        }
    }
}
