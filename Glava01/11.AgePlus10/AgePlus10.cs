using System;

namespace _11.AgePlus10
{
    class AgePlus10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("After 10 years you will be: " + (age+10));
        }
    }
}
