using System;

namespace ConsoleApplication9
{
    public class Worker
    {
        public string name;
        public string surmname;
        public double rate;
        public double days;

        public void GetSalary()
        {
            double salary = rate * days;
            Console.WriteLine(salary);
        }
        
    }
}