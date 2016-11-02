using System;

namespace _07.SumFiveNumber
{
    class SumFiveNumber
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете пет числа и отпечатва тяхната сума. 
             * При невалидно въведено число да се подкани потребителя да въведе друго число.*/

            long sum = 0, a;
            Console.Write("Колко числа искате да сумирате: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("Въведи число No{0}: ", i);
                bool check = long.TryParse(Console.ReadLine(), out a);
                sum += a;

                while (check  == false)
                {
                    Console.Write("Insert a valid number No{0}: ", i);
                    check = long.TryParse(Console.ReadLine(), out a);
                }
            }
            Console.WriteLine("Сумата на числата е: " + sum);


        }
    }
}
