using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] sentenceArr = sentence.Split(' ');
            Array.Reverse(sentenceArr);
            for (int i = 0; i < sentenceArr.Length; i++)
            {
                Console.Write(sentenceArr[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}