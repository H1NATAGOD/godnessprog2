using System;

namespace ConsoleApplication6
{
    public class Numbers
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }
        
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
            
        }


        public void Chagenumbs()
        {
            Number1 = int.Parse(Console.ReadLine());
            Number2 = Int32.Parse(Console.ReadLine());
            
        }


        public void cout()
        {
            Console.WriteLine($"{Number1} {Number2}");
            
        }

        public void choice()
        {
            if (Number1 > Number2 )
            {
                Console.WriteLine($"number 1 is bigger");
            }
            else if(Number1 < Number2)
            {
                Console.WriteLine($"Number 2 is bigger");
            }
            else
            {
                Console.WriteLine($"This numbers is equal");
            }
            
        }

        public void sum()
        {
            int sum = Number1 + Number2;
            Console.WriteLine($"{sum}");
        }
    }
}