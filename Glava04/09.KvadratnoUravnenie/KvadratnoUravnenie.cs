using System;

namespace _09.KvadratnoUravnenie
{
    class KvadratnoUravnenie
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете коефициентите a, b и c от конзолата и решава уравнението: 
             * ax2+bx+c=0. Програмата трябва да принтира реалните решения на уравнението на конзолата.*/
             
            Console.WriteLine("Програма за решаване на квадратно уравнение: ");
            Console.WriteLine("Въведи а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведи c: ");
            double c  = double.Parse(Console.ReadLine());
            double d = (b * b) - (4*a*c);
            double x1, x2;

            if(d > 0)
            {
                x1 = -(b + Math.Sqrt(d)) / (2 * a);
                x2 = -(b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Дискриминантата е: {0}\nУравнението има два реални корена: {1} и {2}", d ,Math.Round(x1, 2),Math.Round(x2, 2));
            }

            else if (d == 0)
            {
                x1 =(-b)/(2*a);
                Console.WriteLine("Дискриминантата е равна на 0 и уравнението има един реални корени който е {0}", Math.Round(x1,2));
            }
            else if (d < 0)
            {
                Console.WriteLine("Дискриминантата е {0}. По-малка от 0 и уравнението няма реални корени",d);
            }
            Console.ReadKey();
        }
    }
}
