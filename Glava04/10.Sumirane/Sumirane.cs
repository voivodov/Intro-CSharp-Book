using System;

namespace _10.Sumirane
{
    class Sumirane
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която прочита едно цяло число n от конзолата. След това прочита още n на брой числа от конзолата и отпечатва тяхната сума.*/

            long n, sum=0;
            string value;
            Console.WriteLine("Въведето първото число, което искате да сумирате: ");
            bool check = long.TryParse((Console.ReadLine()), out n);
            sum += n;
            do
            {
                Console.WriteLine("Въведете другото цяло число:");
                check = long.TryParse((Console.ReadLine()), out n);
                while (check == false)
                {
                    Console.WriteLine("Грешно число, Опирайте отново: ");
                    check = long.TryParse((Console.ReadLine()), out n);
                }
                sum += n;
                Console.WriteLine("Сумата на числата е: " + sum);
                Console.WriteLine("Искате ли да продължите ?\nНапишете yes за да продължите сумирането или нещо друго за край:");
                value = Console.ReadLine();
            } while ( value == "yes");
        }
     }
}

