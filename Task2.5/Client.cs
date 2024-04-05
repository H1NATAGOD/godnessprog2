using System;

namespace ConsoleApplication8
{
    public class Client
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }   
            set { name = value; }
        }

        public int Age
        {
            get { return age; }                
            set { age = value; }
        }

        public Client() : this("Не указанно")
        {
        
        }

        public Client(string name) : this(name, 18)
        {
        
        }

        public Client(string name, int age)
        {
            this.name = name;     
            this.age = age;
        }

        

        ~Client()
        {
            Console.WriteLine($"{name} has deleted");
        }
    }
}