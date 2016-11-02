using System; 

namespace _03.NaiGolqmotoChislo
{
    class NaiGolqmotoChislo
    {
        static void Main(string[] args)
            
        {
            /*Напишете програма която намира най-голямото по стойност число, измежду три дадени числа.*/

            Console.WriteLine("Въведи три числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if(number1 > number3)
                {
                    Console.WriteLine("Най-Голямото число е: "+ number1);
                }
            }

            if (number2 > number1)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("Най-Голямото число е: " + number2);
                }
            }

            if (number3 > number2)
            {
                if (number3 > number1)
                {
                    Console.WriteLine("Най-Голямото число е: " + number3);
                }
            }
        }
    }
}
