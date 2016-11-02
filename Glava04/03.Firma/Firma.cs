using System;

namespace _03.Firma
{
    class Firma
    {
        static void Main(string[] args)
        {
            /* Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер.
               Глава 4. Вход и изход от конзолата 191
               Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.*/

            Console.WriteLine("Име на фирмата: ");
            string firma = Console.ReadLine();
            Console.WriteLine("Град на фирмата: ");
            string adres = Console.ReadLine();
            Console.WriteLine("Телефон на фирмата: ");
            string telf = Console.ReadLine();
            Console.WriteLine("Факс на фирмата: ");
            string fax = Console.ReadLine();
            Console.WriteLine("Website на фирмата: ");
            string web = Console.ReadLine();
            Console.WriteLine("Вашето име: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Вашета фамилия: ");
            string fam = Console.ReadLine();
            Console.WriteLine("Вашия телефон: ");
            string tel = Console.ReadLine();
            Console.WriteLine("Добре дошли ! " + ime + " " + fam + "\nВашия телефон: "+ tel + " е приет в базата дани на нашата фирма " + 
                firma + " с адрес град " + adres + " и телефон " + telf + "\nOчакваме вашето CV на факс: " + fax +
                "\nМоля регистрирайте се в фирмения ни сайт: " + web + "\nЩе се свържем с вас за допълнитени разеснения.\nПоздрави!");
        }
    }
}
