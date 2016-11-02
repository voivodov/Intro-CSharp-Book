using System; 

namespace _01.RazmqnaNaStoinosti
{
    class RazmqnaNaStoinosti
    {
        static void Main(string[] args)
        {
            /*Да се напише if-конструкция, която проверява стойността на две целочислени променливи и разменя техните стойности, 
             * ако стойността на първата променлива е по-голяма от втората.*/

            Console.WriteLine("Въведете число No1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете число No2:");
            int number2 = int.Parse(Console.ReadLine());

            if(number1>number2)
            {
                int number3 = number2;
                number2 = number1;
                number1 = number3;
                Console.WriteLine("Число No1: " + number1);
                Console.WriteLine("Число No2: " + number2);
            }
            else
            {
                Console.WriteLine("Число No1: " + number1);
                Console.WriteLine("Число No2: " + number2);
            }
        }
    }
}
