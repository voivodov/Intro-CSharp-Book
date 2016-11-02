using System;

namespace _04.TretiBit0ili1
{
    class TretiBit0ili1
    {
        static void Main(string[] args)
        {
            // Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.

            uint num = uint.Parse(Console.ReadLine());
            if ((num & (8)) == 0)
            {
                Console.WriteLine("Tretoto bit na chisloto ne e 1 !!!");
            }
            else
            {
                Console.WriteLine("Tretoto chislo na bita e 0 !!!");
            }
        }
    }
}
