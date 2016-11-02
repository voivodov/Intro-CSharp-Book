using System;

namespace _08.TochkaVOkrujnost
{
    class TochkaVOkrujnost
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали дадена точка О(x, y) е вътре в окръжността К((0, 0), 5). 
            //Пояснение: точката(0, 0) е център на окръжността, а радиусът й е 5.

            Console.WriteLine("Въведете кординати на точка и разберете дали е в окружността K");
            Console.WriteLine("Кординати по X: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Кординати по Y: ");
            int b = int.Parse(Console.ReadLine());
            if ((a * b) < 25)
            {
                Console.WriteLine("Точката е в окръжността!!!");
            }

            else Console.WriteLine("Точката не съвпада с окръжността!!!");
        }
    }
}
