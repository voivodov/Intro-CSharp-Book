using System;

namespace _13.ЕxchangeVariable
{
    class ЕxchangeVariable
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
        }
    }
}
