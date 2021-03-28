using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugaday_chislo
{
    class Program
    {
        static void Main(string[] args)
        {            
        
            int k = 0;
            char g='a';
            Random rand = new Random();//Random number creation
            int i = rand.Next(100);
            int count = 1;//attempt counter
            //the function of the game itself
            void game()
            {
                //introduction
                Console.WriteLine("The computer has guessed a number from 0 to 99.Try to guess it in ten attempts.\n");
                Console.WriteLine(" Rools of the game\n1)The number you enter must be between 0 and 99\n" +
                                  "2)The number you enter must be an integer and not a letter or other symbol\n" +
                                  "3)You have 10 attempts to guess the number\n");
                Console.WriteLine("Small hints");
                //hints
                if (i < 50) Console.WriteLine("Number less than 50");
                else Console.WriteLine("A number greater than or equal to 50");
                if (i % 2 == 0)
                {
                    Console.WriteLine("The number is even ");
                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine("The number is odd");
                }

                while (count <= 10)
                {
                    if (count > 0)
                    {
                        n();
                        // number input function
                        void n()
                        {
                            Console.WriteLine("Enter a number. Attempt № " + count + ":");
                            string inp = Console.ReadLine();

                            if (Int32.TryParse(inp, out k))
                            {
                                if (i < k)
                                {
                                    Console.WriteLine("A number less than the one you entered");
                                }
                                  else if (i > k)
                                  {
                                    Console.WriteLine("Number greater than the number you entered");
                                  }
                                     if (k < 0 || k > 99)
                                     {
                                        Console.WriteLine("Invalid input.Enter a number from 0 to 99");
                                        n();
                                     }                               
                            }
                            else
                            {
                                Console.WriteLine("Invalid input format.Read the rools");
                                n();
                            }
                        }
                        //victory
                        if (i == k)
                        {
                            Console.WriteLine("Yes! The computer made a number " + k + "!");

                            break;
                        }
                        count++;

                    }
                        //Loss                   
                    if (count == 11)
                    {
                        Console.WriteLine("Alas, you did not guess the hidden number. It was a number" + i + "!");
                       
                        break;
                    }
                }
            }
            // game
            game();
            //repeat game
            Console.WriteLine("Try again? (a= Yes, another symbols = No)");
            string inw = Console.ReadLine();
            if (Char.TryParse(inw, out g))
            {
                count = 0;
                if (g == 'a')
                {
                    game();
                                      
                }
                else
                {
                    Console.WriteLine(" Thank you for trying out my game.Goodbay");                  
                    Console.ReadLine();
                }
            }
        }
    }
}