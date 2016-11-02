using System;
namespace _02.LiceIObikolkaNaKrug
{
    class LiceIObikolkaNaKrug
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговото лице и обиколка. */

            Console.WriteLine("Въведи радиуса на кръгът: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на кръгът е: " + Math.Round(Math.PI*r*r,2));
            Console.WriteLine("Oбиколката на кръгът е: " + Math.Round(Math.PI * r * 2,2));

        }
    }
}
