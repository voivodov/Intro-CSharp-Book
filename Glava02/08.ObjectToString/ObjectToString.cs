using System;

namespace _08.ObjectToString
{
    class ObjectToString
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World!";
            object obj = str1 + str2;
            string sobj = obj.ToString();
            Console.WriteLine(sobj);
        }
    }
}
