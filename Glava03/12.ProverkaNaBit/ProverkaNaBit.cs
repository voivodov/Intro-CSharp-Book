using System; 

namespace _12.ProverkaNaBit
{
    class ProverkaNaBit
    {
        static void Main(string[] args)
        {
            // Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1.Пример v = 5, p = 1-> false.

            Console.WriteLine("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете позиция: ");
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 1 ? "Числото на тази позиция е 1" : "Числото на тази позиция е 0");
        }
    }
}
