using System;

namespace _01.ChetnoNechetno
{
    class ChetnoNechetno
    {
        static void Main(string[] args)
        {
            //Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

            Console.WriteLine("Въведете число и разберете дали е четно или нечетно: ");
            long num = long.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("Числото е Четно!!!");
            }
            else
            {
                Console.WriteLine("Числото е Нечетно!!!");
            }
        }
    }
}
