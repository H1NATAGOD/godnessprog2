using System;

namespace ConsoleApplication7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            time timer = new time();
            timer.timeset();
            for (int i = 0; i < 5; i++)
            {
                timer.count1();
                timer.timesee();
            }
            
            
            for (int i = 0; i < 5; i++)
            {
                timer.count2();
                timer.timesee();
            }
        }
    }
}