using System;

namespace _14.ProveknaOt0Do100ZaProstoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто 
               (т.е. се дели без остатък само на себе си и на единица). */

            Console.WriteLine("Въведи число и разбери дали е просто");
            int input = int.Parse(Console.ReadLine());

            if (input > 1)
            {

                
                for(int i=1; i<= Math.Sqrt(input); i++)
                {
                    
                    Console.WriteLine("Числото {0} не е просто", input);
                else
                        Console.WriteLine("Числото {0} е просто", input);

                }

                
                Console.WriteLine("Числото {0} не е просто", input);
                else
                        Console.WriteLine("Числото {0} е просто", input);

            }
            else
                Console.WriteLine("Невярно число!!!");

         }
        }
    }

