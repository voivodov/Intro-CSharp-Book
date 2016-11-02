using System;

namespace _04.NamalqvashtiChisla
{
    class NamalqvashtiChisla
    {
        static void Main(string[] args)
        {
            /*Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.*/

            Console.WriteLine("Въведи три числа:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("В намаляващ ред: ");

            if((num1 > num2) && (num1 > num3)) 
            {
                if((num2 > num3))
                {
                    Console.Write(num1 + " " + num2 + " "+ num3);
                }
                else
                {
                    Console.Write(num1 + " " + num3 + " " + num2);
                }
                
            }

            else if ((num2 > num1) && (num2 > num3))
            {
                if ((num1 > num3))
                {
                    Console.Write(num2 + " " + num1 + " " + num3);
                }
                else
                {
                    Console.Write(num2 + " " + num3 + " " + num1);
                }
            }

            else if ((num3 > num2) && (num3 > num1))
            {
                if ((num2 > num1))
                {
                    Console.Write(num3 + " " + num2 + " " + num1);
                }
                else
                {
                    Console.Write(num3 + " " + num1 + " " + num2);
                }
            }
        }
    }
}
