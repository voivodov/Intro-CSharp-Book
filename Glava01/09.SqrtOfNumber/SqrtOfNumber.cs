using System;

namespace _09.SqrtOfNumber
{
    class SqrtOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to sqrt: ");
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
        }
    }
}
