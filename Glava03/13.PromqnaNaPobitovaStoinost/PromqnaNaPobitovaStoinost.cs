using System;

namespace _13.PromqnaNaPobitovaStoinost
{
    class PromqnaNaPobitovaStoinost
    {
        static void Main(string[] args)
        {
            /* Дадено е число n, стойност v (v = 0 или 1) и позиция p. 
             * Напишете поредица от операции, които да променят стойността на n, така че битът на позиция p да има стойност v. 
             * Пример n=35, p=5, v=0 -> n=3. Още един пример: n=35, p=2, v=1 -> n=39. */

            Console.WriteLine("Въведете Число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете Позиция: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете Стойност: ");
            int v = int.Parse(Console.ReadLine());
            if (v==0)
                n = n & (~(1 << p));
            else if (v==1)
                    n = n | (1 << p);

            Console.WriteLine("Стойноста на числото след промяната е: "+ n);

        }
    }
}
