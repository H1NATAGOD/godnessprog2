using System;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Train Sam = new Train();
            Sam.travel = "Porter - Los Angeles";
            Sam.datebirth = new DateTime(2005, 12, 3);
            Sam.numberOfTrain = 253;

            Train NewYork = new Train();
            NewYork.travel = "Porter - New York";
            NewYork.datebirth = new DateTime(2005, 12, 3);
            NewYork.numberOfTrain = 234;
            
            
            Train Washington = new Train();
            Washington.travel = "Porter - Washington";
            Washington.datebirth = new DateTime(2005, 12, 3);
            Washington.numberOfTrain = 3543;
            
            
            
            Train Carrolina = new Train();
            Carrolina.travel = "Porter - Carrolina";
            Carrolina.datebirth = new DateTime(2005, 12, 3);
            Carrolina.numberOfTrain = 432;
            
            Console.WriteLine($"Suggested ways: {Sam.numberOfTrain} {Sam.travel}\n{Washington.numberOfTrain} {Washington.travel}\n{Carrolina.numberOfTrain} {Carrolina.travel}\n{NewYork.numberOfTrain} {NewYork.travel}" );
            Console.WriteLine($"To see the departure time, enter the train number");
            
            int numberOfTrain1 = Int32.Parse(Console.ReadLine());
            switch (numberOfTrain1)
            {
                case 253:
                    Console.WriteLine($" {Sam.numberOfTrain} {Sam.travel} {Sam.datebirth}");
                    break;
                case 3543:
                    Console.WriteLine($" {Washington.numberOfTrain} {Washington.travel} {Washington.datebirth}");
                    break;
                case 432 :
                    Console.WriteLine($" {Carrolina.numberOfTrain} {Carrolina.travel} {Carrolina.datebirth}");
                    break;
                case 234 :
                    Console.WriteLine($" {NewYork.numberOfTrain} {NewYork.travel} {NewYork.datebirth}");
                    break;
                default:
                    Console.WriteLine($"Sorry, now we don't have his way. Look at other directions(\nну блин, как так(((((");
                    break;
            }
        }
    }
}