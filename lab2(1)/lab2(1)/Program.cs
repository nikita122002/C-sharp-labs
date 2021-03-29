using System;
using System.Threading;
namespace Laboratornaya2_3_
{
    class Program
    {
        static void language()
        {
            Console.WriteLine("Choose language: ru-Russian,bg-Bulgarian, en-English, fr-French,hu-Hungarian");
        }
        static void Main()
        {
            language();
            string lang;
            lang = Console.ReadLine();
            while (lang != "en" && lang != "ru" && lang != "fr" && lang!="hu" && lang != "bg")
            {
                Console.WriteLine("Povtorite vvod (you can write only 2 letters as above) :");
                lang = Console.ReadLine();
                Console.Clear();
                language();
            }
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            for (int i = 1; i <= 12; i++)
            {
                DateTime langu = new DateTime(2021, i, 3);
                Console.WriteLine("{0:MMMM }", langu);
            }
            Console.ReadKey();
        }
    }
}