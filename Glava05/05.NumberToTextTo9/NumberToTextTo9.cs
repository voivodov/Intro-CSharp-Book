using System;

namespace _05.NumberToTextTo9
{
    class NumberToTextTo9
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на български език.*/

            Console.WriteLine("Въведи число: ");
            int num = int.Parse(Console.ReadLine());

            if (num<=0)
                Console.WriteLine("Числото е твърде малко");
            if (num == 1)
                Console.WriteLine("едно");
            else if (num == 2)
                Console.WriteLine("две");
            else if (num == 3)
                Console.WriteLine("три");
            else if (num == 4)
                Console.WriteLine("четри");
            else if (num == 5)
                Console.WriteLine("пет");
            else if (num == 6)
                Console.WriteLine("шест");
            else if (num == 7)
                Console.WriteLine("седем");
            else if (num == 8)
                Console.WriteLine("осем");
            else if (num == 9)
                Console.WriteLine("девет");
            else if (num >= 10)
                Console.WriteLine("Числото е твърде голямо");
        }
    }
}
