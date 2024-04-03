using System;

namespace ConsoleApplication10
{
    public class Worker
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }   
        }

        private string surname;
        
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }   
        }
        
        
        public double rate;
        
        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }   
        }
        public double days;
        
        
        public double Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }   
        }

        public void GetSalary()
        {
            double salary = Rate * Days;
            Console.WriteLine(salary);
        }

        public void Cout()
        {
            Console.WriteLine($"{name} {surname} {rate} {days}");
        }
    }
}