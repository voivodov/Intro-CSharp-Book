using System;

namespace _11.PobitovoOtmestvane
{
    class PobitovoOtmestvane
    {
        static void Main(string[] args)
        {
            /* Дадено е число n и позиция p. Напишете поредица от операции, които да отпечатат стойността на бита на позиция p от числото n (0 или 1). 
             * Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0. */

            Console.WriteLine("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете отместване(от дясно на ляво): ");
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            Console.WriteLine("Бита e: ");
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}
