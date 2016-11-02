using System;

namespace _13.Sumirane0._001
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която пресмята сумата (с точност до 0.001): 1+ 1/2 + 1/3 + 1/4 + 1/5 + ...*/
            float sum=0.00f;
            for(float i=0.0001f; i<=1.001f; i+=0.0001f)
            {
                sum += 0.01f/i;
                Console.WriteLine(sum);asdasdasd
            }
        }
    }
}
