using System;

namespace _09.TochkaVOkrujnostIIzvunKvadrat
{
    class TochkaVOkrujnostIIzvunKvadrat
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). 
            //Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.

            Console.WriteLine("Въведете Кординати на Точката\n Кординати по X: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Кординати по X: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            if ((c < 25) & (c > 9))
            {
                Console.WriteLine("Точката е в другата окръжност и извън квадрата!!!");
            }

            else Console.WriteLine("Точката не е в другата окръжност!!!");
        }
    }
}
