using System;

namespace _01.Chete3ChislaOtTipInt
{
    class Chete3ChislaOtTipInt
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума. */

            Console.WriteLine("Въведи 3 числа: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведохте число 1=" + num1);
            Console.WriteLine("Въведохте число 2=" + num2);
            Console.WriteLine("Въведохте число 3=" + num3);
        }
    }
}
