using System;

namespace _02.PokazvaZnakaOtSubiranetoNaTriChisla
{
    class PokazvaZnakaOtSubiranetoNaTriChisla
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която показва знака (+ или -) от произведението на три реални числа, 
             * без да го пресмята. Използвайте последователност от if оператори.*/

            Console.WriteLine("Въведи три числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if ((number1 + number2 + number3) > 0)
            {
                Console.WriteLine("Сбора на числата е полужителен {0}", (number1 + number2 + number3));
            }
            else
            {
                Console.WriteLine("Сбора на числата е отрицателен {0}", (number1 + number2 + number3));
            }
        }
    }
}
