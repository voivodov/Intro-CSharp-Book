using System;

namespace _11.OtpechatvaneNaChisla
{
    class OtpechatvaneNaChisla
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която прочита цяло число n от конзолата и отпечатва на конзолата всички числа в интервала [1…n], всяко на отделен ред*/

            long number;
            Console.WriteLine("Въведи число: ");
            bool chekNumber = long.TryParse(Console.ReadLine(), out number);
            while(chekNumber == false)
            { 
                Console.WriteLine("Въведи коректно число: ");
                chekNumber = long.TryParse(Console.ReadLine(), out number);
            }
            for(int i = 1; i<=number; i++)
                Console.WriteLine(i);
        }
    }
}
