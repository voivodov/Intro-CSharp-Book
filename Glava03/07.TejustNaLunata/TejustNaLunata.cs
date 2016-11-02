using System;

namespace _07.TejustNaLunata
{
    class TejustNaLunata
    {
        static void Main(string[] args)
        {
            //Силата на гравитационното поле на Луната е приблизително 17% от това на Земята. 
            //Напишете програма, която да изчислява тежестта на човек на Луната, по дадената тежест на Земята.

            Console.Write("Въведете килограми на земята: ");
            double nazemqta = double.Parse(Console.ReadLine());
            double nalunata = nazemqta * 0.17;
            Console.WriteLine("Еквивалентните килограми на луната са: " 
                + nalunata);
        }
    }
}
