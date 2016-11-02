using System;

namespace _05.ChisleDeleniNaPetMejduDrugiDve
{
    class ChisleDeleniNaPetMejduDrugiDve
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата две цели числа (int) 
             * и отпечатва колко числа има между тях, такива, че остатъкът им от деленето на 5 да е 0. 
             * Пример: в интервала (17, 25) има 2 такива числа.*/

            Console.WriteLine("Въведи 2 цели числа и разбери колко числа има между тях, който се делят на 5: ");
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
            long count = 0;
            for(long i = number1; i <= number2; i++)
            {
                if((i % 5) == 0)
                    count++;
            }
            Console.WriteLine("В интервала има {0} числа който се делят на 5" , count);


        }
    }
}
