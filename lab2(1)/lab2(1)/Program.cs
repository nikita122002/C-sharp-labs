using System;
using System.Threading;
namespace Laboratornaya2_3_
{
    class Program
    {
        static void Language()
        {
            Console.WriteLine("Choose language: ru-Russian,bg-Bulgarian, en-English, fr-French,hu-Hungarian");
        }
        static void Main()
        {
            Language();
            string Lang;
            Lang = Console.ReadLine();
            while (Lang != "en" && Lang != "ru" && Lang != "fr" && Lang!="hu" && Lang != "bg")
            {
                Console.WriteLine("Repeat the input (you can write only 2 letters as above) :");
                Lang = Console.ReadLine();
                Console.Clear();
                Language();
            }
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Lang);
            for (int i = 1; i <= 12; i++)
            {
                DateTime langu = new DateTime(2021, i, 3);
                Console.WriteLine("{0:MMMM }", langu);
            }
            Console.ReadKey();
        }
    }
}