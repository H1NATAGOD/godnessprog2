using System;

namespace ConsoleApplication7
{
    public class time
    {
        private int timer;
         
        public int Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }

        public void count1()
        {
            Timer++;
        }

        public void count2()
        {
            Timer--;
        }

        public void timeset()
        {
            Console.WriteLine($"Get number");
            string numb = Console.ReadLine();
            if (numb == "0" || numb == "")
            {
                Timer = 0;
            }
            else
            {
                Timer = Int32.Parse(numb);
            }
        }

        public void timesee()
        {
            Console.WriteLine($"{Timer}");
        }
        
    }
}