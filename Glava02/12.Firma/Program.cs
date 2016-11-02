using System;

namespace _12.Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add new person \nFirst name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age: (from 21 to 55");
            ushort age = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Pol: (m or f)");
            string pol = Console.ReadLine();
            Console.WriteLine("Number of Person at Firms: (from 27560000 to 27569999)");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstName + "\nLast name: " + lastName + "\nAge: " + age + "\nSex: " + pol + "\nNumber in Firms " + num);
        }
    }
}
