using System;

namespace _10.RazmqnaNaCifri
{
    class RazmqnaNaCifri
    {
        static void Main(string[] args)
        {
           /* Напишете програма, която приема за вход четирицифрено число във формат abcd (например числото 2011) 
               и след това извършва следните действия върху него:
                - Пресмята сбора от цифрите на числото(за нашия пример 2 + 0 + 1 + 1 = 4).
                - Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия пример резултатът е 1102).
                - Поставя последната цифра на първо място: dabc(за нашия пример резултатът е 1201).
                - Разменя мястото на втората и третата цифра: acbd(за нашия пример резултатът е 2101).*/

           Console.WriteLine("Въведи 4-цифрено число: ");
            int value = int.Parse(Console.ReadLine());
            int a = value / 1000;
            int b = (value / 100) % 10;
            int c = (value % 100) / 10;
            int d = value % 10;
            Console.WriteLine("Сборът на отделните цифри е:");
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("Изписано наобратно числото е:");
            Console.Write(d);
            Console.Write(c);
            Console.Write(b);
            Console.WriteLine(a);
            Console.WriteLine("С последна цифра поставена като първа числото изглежда така:");
            Console.Write(d);
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(c);
            Console.WriteLine("С разменени втора и трета цифра числото изглежда така:");
            Console.Write(a);
            Console.Write(c);
            Console.Write(b);
            Console.Write(d);
            Console.WriteLine();
        }
    }
}
