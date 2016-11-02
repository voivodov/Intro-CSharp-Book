using System;

namespace _12.PrintRedicataNaFibonachi
{
    class PrintRedicataNaFibonachi
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...*/
            
            decimal a = 0, b = 1, result = 1, sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += result;
                result = a + b;
                a = b;
                b = result;
                Console.WriteLine(i + ". " + result);
            }
        }
    }
}
