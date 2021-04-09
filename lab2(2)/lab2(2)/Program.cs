using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int one=0, two=0, three=0, four=0, five=0, six=0, seven=0, eight=0, nine=0, zero=0;
            DateTime date = DateTime.Now;
            Console.WriteLine( DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss"));            
            string Time = date.ToString("yyyyMMddHHmmss");
            Console.WriteLine(Time);
            ulong i = Convert.ToUInt64(Time);

            do
            {
               ulong d = i % 10;
                           
                switch(d)
                {
                    case 1:
                        one += 1;
                        break;
                    case 2:
                        two += 1;
                        break;
                    case 3:
                        three += 1;
                        break;
                    case 4:
                        four += 1;
                        break;
                    case 5:
                        five += 1;
                        break;
                    case 6:
                        six += 1;
                        break;
                    case 7:
                        seven += 1;
                        break;
                    case 8:
                        eight += 1;
                        break;
                    case 9:
                        nine += 1;
                        break;
                    case 0:
                       zero += 1;
                        break;

                }
                
                i /= 10;
            } while (i>0);
             Console.WriteLine("\nКоличество 0:"+ zero);
             Console.WriteLine("Количество 1:"+ one);
             Console.WriteLine("Количество 2:"+ two);
             Console.WriteLine("Количество 3:"+ three);
             Console.WriteLine("Количество 4:"+ four);
             Console.WriteLine("Количество 5:"+ five);
             Console.WriteLine("Количество 6:"+ six);
             Console.WriteLine("Количество 7:"+ seven);
             Console.WriteLine("Количество 8:"+eight);
             Console.WriteLine("Количество 9:"+ nine);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
