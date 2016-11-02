using System;

namespace _06.PoGolqmoChislo
{
    class PoGolqmoChislo
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете две числа от конзолата и отпечатва по-голямото от тях. 
             * Решете задачата без да използвате условни конструкции.*/

            Console.WriteLine("Въведете две числа и разберете кое е по-голямо: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("По-голямото число е: " + Math.Max(number1,number2));
            Console.WriteLine("По-малкото число е: " + Math.Min(number1, number2));
        }
    }
}
