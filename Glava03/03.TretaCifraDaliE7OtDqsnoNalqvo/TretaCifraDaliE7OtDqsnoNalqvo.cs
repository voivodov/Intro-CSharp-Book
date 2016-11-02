using System;

namespace _03.TretaCifraDaliE7OtDqsnoNalqvo
{
    class TretaCifraDaliE7OtDqsnoNalqvo
    {
        static void Main(string[] args)
        {
            // Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.

            Console.WriteLine("Въведи чило и разбери дали третата цифра от дясно наляво е 7: ");
            long num = long.Parse(Console.ReadLine());
            
            if (((num / 100) % 10) == 7)
            {
                Console.WriteLine("Третата цифра е 7 !!!");
            }
            else
                Console.WriteLine("Третата цифра не е 7 !!!");
        }
    }
}
