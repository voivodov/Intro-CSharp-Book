using System;

namespace _07.StringToObject
{
    class StringToObject
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World!";
            object obj = str1 + str2;
            Console.WriteLine(obj);
        }
    }
}
