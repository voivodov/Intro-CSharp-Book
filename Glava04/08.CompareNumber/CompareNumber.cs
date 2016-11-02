using System;

namespace _08.CompareNumber
{
    class CompareNumber
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете пет числа от конзолата и отпечатва най-голямото от тях.*/


            Console.WriteLine("Въведи 5 числа: ");
            Console.WriteLine("Число No1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число No2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число No3: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число No4: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число No5: ");
            int number5 = int.Parse(Console.ReadLine());

            if ((number1 > number2) && (number1 > number3) && (number1 > number4) && (number1 > number5))
                Console.WriteLine("Най-голямото е число No1: " + number1);

            else if ((number2 > number1) && (number2 > number3) && (number2 > number4) && (number2 > number5))
                Console.WriteLine("Най-голямото е число No2: " + number2);

            else if ((number3 > number2) && (number3 > number1) && (number3 > number4) && (number3 > number5))
                Console.WriteLine("Най-голямото е число No3: " + number3);

            else if ((number4 > number2) && (number4 > number3) && (number4 > number1) && (number4 > number5))
                Console.WriteLine("Най-голямото е число No4: " + number4);

            else if ((number5 > number2) && (number5 > number3) && (number5 > number4) && (number5 > number1))
                Console.WriteLine("Най-голямото е число No5: " + number5);


        }
    }
}
