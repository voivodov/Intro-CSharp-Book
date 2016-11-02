using System; 

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for(int i = 1; i<count; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                if (newNumber > max)
                    max = newNumber;
            }
            Console.WriteLine(max);
        }

    }
}
