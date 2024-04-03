using System;
using System.Collections.Generic;

namespace ConsoleApplication12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string quest = Console.ReadLine();

            Dictionary<char, int> idk = new Dictionary<char, int>()
            {


                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int result = 0;

                for (int i = 0; i < quest.Length; i++)
            {
                if (i < quest.Length - 1 && idk[quest[i]] < idk[quest[i + 1]])
                {
                    result -= idk[quest[i]];
                }
                else
                {
                    result += idk[quest[i]];
                }
            }
                Console.WriteLine($"{result}");
        }
    }
}