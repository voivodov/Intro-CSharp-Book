using System;

namespace _10.Num100_2__3_4__5_
{
    class NumTo100
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100 ; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);

                else
                    Console.WriteLine(-i);

            }
        }
    }
}
